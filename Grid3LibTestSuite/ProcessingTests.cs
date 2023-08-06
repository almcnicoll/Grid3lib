using Grid3lib;
using Grid3lib.XmlNodeTag;
using System.IO.Compression;
using System.IO;
using System.Drawing.Imaging;
using SixLabors.ImageSharp;

namespace Grid3LibTestSuite
{

    public class ProcessingTests
    {
        [Fact]
        public void CompressGridsetJPEGs()
        {
            // Create test file by copying from source
            System.IO.File.Copy(@"G:\My Drive\Florence\Grid3\backup\grids\My Stories.gridset", @"G:\My Drive\Florence\Grid3\backup\grids\My Stories - Test.gridset.zip", true);
            // Run process on test file
            GridSet.processFiles(@"G:\My Drive\Florence\Grid3\backup\grids\My Stories - Test.gridset.zip", wildcard: @"*.jp*", ProcessingTests.RecompressJPEG);
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
                    SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder jpegEncoder = new SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder();
                    jpegEncoder.Quality = quality;
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

        /*
        public static Stream RecompressMP3(string filename, Stream input)
        {
            int quality = 60;

            Stream output = new MemoryStream();
            using (Image originalImage = Image.Load(input))
            {
                SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder jpegEncoder = new SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder();
                jpegEncoder.Quality = quality;
                originalImage.SaveAsJpeg(output, jpegEncoder);
                return output;
            }
        }
        */
    }
}
