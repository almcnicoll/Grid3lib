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
            GridSet.processFiles(@"G:\My Drive\Florence\Grid3\backup\grids\My Stories - Test.gridset", wildcard: @"*.jp*", ProcessingTests.RecompressJPEG);
        }

        public static Stream RecompressJPEG(string filename, Stream input)
        {
            int quality = 30;

            FileStream fs = new FileStream(@"C:\Users\GZYBK12\Desktop\tmp.jpg", FileMode.Append);
            input.CopyTo(fs); fs.Close();
            input.Seek(0, SeekOrigin.Begin);

            Stream output = new MemoryStream();
            using (Image originalImage = Image.Load(input))
            {
                SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder jpegEncoder = new SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder();
                jpegEncoder.Quality = quality;
                originalImage.SaveAsJpeg(output, jpegEncoder);
                return output;
            }
        }
    }
}
