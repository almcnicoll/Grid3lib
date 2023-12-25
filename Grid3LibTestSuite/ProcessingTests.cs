using Grid3lib;
using Grid3lib.XmlNodeTag;
using System.IO.Compression;
using System.IO;
using System.Drawing.Imaging;
using SixLabors.ImageSharp;
//using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using System.Diagnostics;
using Xunit.Sdk;
using System.Text.RegularExpressions;
using System.IO.Pipes;
using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Reflection;

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


        [Theory]
        [InlineData(@"C:\Users\Public\Documents\Smartbox\Grid 3\Remote Editors\florence@almcnicoll.co.uk\Grid Sets\SuperduperCore.gridset", @"G:\My Drive\Florence\Grid3\backup\grids\SuperduperCore.largefiles.log")]
        public void ListLargeGridsetMedia(string originalFile, string logFile)
        {
            // List media larger than 1Mb
            Dictionary<string, long> largeFiles = GridSet.listFiles(gridsetFile: originalFile, largerThan: (long)(0.25 * 1024 * 1024));
            List<string> output = (from KeyValuePair<string, long> entry in largeFiles
                                   orderby entry.Value descending
                                   select String.Format("{0,16} - {1}", entry.Value, entry.Key)).ToList();
            System.IO.File.WriteAllLines(logFile, output);
        }

        [Theory]
        [InlineData(@"C:\Users\Public\Documents\Smartbox\Grid 3\Remote Editors\florence@almcnicoll.co.uk\Grid Sets\SuperduperCore.gridset", @"G:\My Drive\Florence\Grid3\backup\grids\SuperDuperCore.comp.gridset")]
        public void CompressAllGridsetMedia(string originalFile, string testFile)
        {
            // Create test file by copying from source
            System.IO.File.Copy(originalFile, testFile, true);
            // Run MP3 process on test file
            GridSet.processFiles(testFile, wildcard: @"*.mp*", ProcessingTests.RecompressMP3);
            // Run JPEG process on test file
            GridSet.processFiles(testFile, wildcard: @"*.jp*", ProcessingTests.RecompressJPEG);
        }

        [Fact]
        public void CompressGridsetJPEGs()
        {
            // Create test file by copying from source
            string testFile = @"G:\My Drive\Florence\Grid3\backup\grids\My Stories - JPEG Test.gridset.zip";
            System.IO.File.Copy(@"G:\My Drive\Florence\Grid3\backup\grids\My Stories.gridset", testFile, true);
            // Run JPEG process on test file
            GridSet.processFiles(testFile, wildcard: @"*.jp*", ProcessingTests.RecompressJPEG);
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

        [Theory]
        [InlineData("AnimDev", @"G:\My Drive\Florence\Grid3\dev\AnimDev", @"G:\My Drive\Florence\Grid3\dev\AnimDev.gridset")]
        public void MakeFromFolder(string gridsetName, string sourceFolder, string destinationFile)
        {
            Assembly? entryAssembly = System.Reflection.Assembly.GetEntryAssembly();
            AssemblyName? entryAssemblyName = null;
            if (entryAssembly != null) { entryAssemblyName = entryAssembly.GetName(); }

            string tempFolder = "";
            if (entryAssemblyName == null || entryAssemblyName.Name == null)
            {
                tempFolder = Path.Combine(Path.GetTempPath(), "Grid3lib");
            }
            else
            {
                tempFolder = Path.Combine(Path.GetTempPath(), entryAssemblyName.Name);
            }

            Directory.CreateDirectory(tempFolder);
            string tempOutputFileName = Path.Combine(tempFolder, (gridsetName == null ? "temp" : gridsetName) + ".gridset");
            ZipFile.CreateFromDirectory(sourceFolder, tempOutputFileName, CompressionLevel.Optimal, false);
            System.IO.File.Copy(tempOutputFileName, destinationFile, overwrite: true);
        }

        [Theory]
        [InlineData(@"G:\My Drive\Florence\Grid3\backup\grids\SuperduperCore.gridset", @"G:\My Drive\Florence\Grid3\backup\grids\SuperduperCore.reduced.gridset", @"G:\My Drive\Florence\Grid3\backup\grids\LifeLessons.gridset")]
        public void SplitOutGrids(string originalFile, string testFile1, string testFile2)
        {
            // Load GridSet
            GridSet? gridSetOriginal = GridSet.Load(originalFile);
            if (gridSetOriginal == null) { return; }

            // Find the Life Lessons grid
            Grid? lifeLessonsGrid = gridSetOriginal.getGrid("Life Lesson homepage");
            if (lifeLessonsGrid == null) { return; }

            // Split it into its own GridSet
            // TODO - check how many grids being split out - it seems huge! 388 in current test data run
            GridSet lifeLessonsGridSet = lifeLessonsGrid.moveToNewGridSet("Life Lessons");

            // Save GridSets
            gridSetOriginal.SaveAs(testFile1);
            lifeLessonsGridSet.SaveAs(testFile2);
        }
    }
}
