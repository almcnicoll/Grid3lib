using Grid3lib;
using Grid3lib.XmlNodeTag;
using System.IO.Compression;
using System.IO;
using System.Drawing.Imaging;
using SixLabors.ImageSharp;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
//using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using System.Diagnostics;
using Xunit.Sdk;
using System.Text.RegularExpressions;
using System.IO.Pipes;
using System;

namespace Grid3LibTestSuite
{

    public class ProcessingTests
    {
        [Theory]
        [InlineData(@"c:\Program Files\Shotcut", @"C:\Users\GZYBK12\AppData\Local\Temp\04_Freestyler.mp3", @"C:\Users\GZYBK12\AppData\Local\Temp\04_Freestyler_output.mp3", 96)]
        public static void RecompressMP3File(string binaryPath, string inputFile, string outputFile, int targetKbps)
        {
            Regex rxFfprobeBitrate = new Regex("bit_rate=(?<bitrate>\\d+)");
            string ffmpegPath = Path.Combine(binaryPath, "ffmpeg");
            string ffprobe = Path.Combine(binaryPath, "ffprobe");

            // Probe kbps
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffprobe,
                    Arguments = String.Format("-v quiet -select_streams a:0 -show_entries stream=bit_rate -of default=noprint_wrappers=1 \"{0}\"", inputFile),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            process.Start();
            string probeOutput = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            int currentKbps = 9999;
            if (rxFfprobeBitrate.IsMatch(probeOutput))
            {
                Match m = rxFfprobeBitrate.Match(probeOutput);
                currentKbps = (int)Math.Round(Double.Parse(m.Groups["bitrate"].Value) / (double)1000);
            }

            // Transcode if needed
            if (currentKbps > targetKbps)
            {
                process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = ffmpegPath,
                        Arguments = String.Format("-y -i {0} -codec:a libmp3lame -b:a 128k -f mp3 {1}", inputFile, outputFile),
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                process.WaitForExit();
                process.Dispose();
            }
            else
            {
                // Otherwise just copy
                System.IO.File.Copy(inputFile, outputFile, true);
            }
        }

        [Fact]
        public void CompressGridsetJPEGs()
        {
            // Create test file by copying from source
            string testFilename = @"G:\My Drive\Florence\Grid3\backup\grids\My Stories - JPEG Test.gridset.zip";
            System.IO.File.Copy(@"G:\My Drive\Florence\Grid3\backup\grids\My Stories.gridset", testFilename, true);
            // Run JPEG process on test file
            GridSet.processFiles(testFilename, wildcard: @"*.jp*", ProcessingTests.RecompressJPEG);
        }

        [Theory]
        [InlineData(@"G:\My Drive\Florence\Grid3\backup\grids\My Stories.gridset", @"G:\My Drive\Florence\Grid3\backup\grids\My Stories - MP3 Test.gridset.zip")]
        [InlineData(@"G:\My Drive\Florence\Grid3\backup\grids\Superdupercore.gridset", @"G:\My Drive\Florence\Grid3\backup\grids\Superdupercore - MP3 Test.gridset.zip")]
        public void CompressGridsetMP3s(string originalFile, string testFile)
        {
            // Create test file by copying from source
            System.IO.File.Copy(originalFile, testFile, true);
            // Run MP3 process on test file
            GridSet.processFiles(testFile, wildcard: @"*.mp*", ProcessingTests.RecompressMP3);
        }

        public static Stream RecompressJPEG(string filename, Stream input)
        {
            int quality = 60;

            input.Seek(0, SeekOrigin.Begin);
            Stream output = new MemoryStream();
            using (Image originalImage = Image.Load(input))
            {
                SixLabors.ImageSharp.Formats.Jpeg.JpegMetadata meta = originalImage.Metadata.GetJpegMetadata();
                // Scale down quality if it's higher than target quality
                if (meta.Quality > quality)
                {
                    SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder jpegEncoder = new SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder { Quality = quality };
                    originalImage.SaveAsJpeg(output, jpegEncoder);
                }
                else
                {
                    // Otherwise just copy the stream
                    input.CopyTo(output);
                }
                return output;
            }
        }


        public static Stream RecompressMP3(string filename, Stream input)
        {
            int quality = 96;

            // Get some temporary filenames
            string tempSourceFile = Path.GetTempFileName();
            string tempOutputFile = Path.GetTempFileName();

            // Write input stream to file
            using (FileStream fileStream = new FileStream(tempSourceFile, FileMode.Create))
            {
                input.CopyTo(fileStream);
            }

            Stream output = new MemoryStream();

            RecompressMP3File(@"c:\program files\shotcut", tempSourceFile, tempOutputFile, quality);

            using (FileStream fs = new FileStream(tempOutputFile, FileMode.Open, FileAccess.Read))
            {
                fs.CopyTo(output);
            }

            //Housekeeping
            System.IO.File.Delete(tempSourceFile);
            System.IO.File.Delete(tempOutputFile);

            // Return output stream
            return output;
        }
    }
}
