using Grid3lib;
using Grid3lib.XmlNodeTag;
using System.IO.Compression;
using System.IO;
using System.Drawing.Imaging;
using SixLabors.ImageSharp;
using MediaToolkit;
using MediaToolkit.Model;
//using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;

namespace Grid3LibTestSuite
{

    public class ProcessingTests
    {
        [Fact]
        public void CompressGridsetJPEGs()
        {
            // Create test file by copying from source
            System.IO.File.Copy(@"G:\My Drive\Florence\Grid3\backup\grids\My Stories.gridset", @"G:\My Drive\Florence\Grid3\backup\grids\My Stories - Test.gridset.zip", true);
            // Run JPEG process on test file
            GridSet.processFiles(@"G:\My Drive\Florence\Grid3\backup\grids\My Stories - Test.gridset.zip", wildcard: @"*.jp*", ProcessingTests.RecompressJPEG);
            GridSet.processFiles(@"G:\My Drive\Florence\Grid3\backup\grids\My Stories - Test.gridset.zip", wildcard: @"*.mp*", ProcessingTests.RecompressMP3);
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
            string tempSourceFile = Path.GetTempFileName();
            string tempOutputFile = Path.GetTempFileName();

            // FFmpeg.SetExecutablesPath(@"c:\program files\Shotcut\");

            using (FileStream fileStream = new FileStream(tempSourceFile, FileMode.Create))
            {
                input.CopyTo(fileStream);
            }

            Stream output = new MemoryStream();
            var inputFile = new MediaFile { Filename = tempSourceFile };
            using (Engine engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                if (inputFile.Metadata.AudioData.BitRateKbs > quality)
                {
                    // If quality needs dropping, do so
                    var outputFile = new MediaFile { Filename = tempOutputFile };
                    engine.Convert(inputFile, outputFile);
                    FileStream fsTemp = new FileStream(tempOutputFile, FileMode.Open, FileAccess.Read);
                    fsTemp.CopyTo(output);
                }
                else
                {
                    // Just copy the stream
                    input.CopyTo(output);
                }
            }
            return output;
        }
    }
}
