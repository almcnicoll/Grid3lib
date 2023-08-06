using System;
using Grid3lib.XmlNodeTag;
using ImageSharp = SixLabors.ImageSharp;

namespace Grid3lib.ToConvert
{
    public class CellImage
    {
        /// <summary>
        /// Specifies the type of image: built into Grid3, part of a 3rd-party symbol library, or a custom image included in the GridSet
        /// </summary>
        public enum CellImageType
        {
            Unknown = 0,
            Grid3x = 1,
            OtherSymbolLibrary = 2,
            CustomImage = 3
        }

        private string __EntryString;
        private string __SymbolLibrary;
        private string __FileName;

        public Cell Parent { get; set; }

        public ImageSharp.Image Image { get; set; }

        /// <summary>
        /// The type of image
        /// </summary>
        public CellImageType ImageType
        { get; set; }

        /// <summary>
        ///  The raw image specification text, including any library prefix
        /// </summary>
        public string EntryString
        {
            get
            {
                switch (ImageType)
                {
                    case CellImageType.Grid3x:
                        return String.Format("[{0}]{1}", __SymbolLibrary, __FileName);
                    case CellImageType.OtherSymbolLibrary:
                        return String.Format("[{0}]{1}", __SymbolLibrary, __FileName);
                    case CellImageType.CustomImage:
                        return __FileName;
                    default:
                        return __FileName;
                }
            }
            set
            {
                __EntryString = value;
                if (__EntryString.Contains("[") && __EntryString.Contains("]"))
                {
                    // It's a library
                    __SymbolLibrary = __EntryString.Substring(__EntryString.IndexOf("[") + 1, __EntryString.IndexOf("]") - __EntryString.IndexOf("[") - 1);
                    if (__SymbolLibrary.ToLower() == "grid3x")
                    {
                        ImageType = CellImageType.Grid3x;
                    }
                    else
                    {
                        ImageType = CellImageType.OtherSymbolLibrary;
                    }
                    __FileName = __EntryString.Substring(EntryString.IndexOf("]") + 1);
                }
                else
                {
                    if (__EntryString.Substring(0, 1) == ".")
                    {
                        ImageType = CellImageType.CustomImage;
                        __FileName = __EntryString;
                    }
                    else
                    {
                        ImageType = CellImageType.Unknown;
                        __FileName = __EntryString;
                    }
                }
            }
        }

        public string SymbolLibrary
        {
            get
            {
                return __SymbolLibrary;
            }
            set
            {
                __SymbolLibrary = value;
            }
        }

        /// <summary>
        /// Returns the filename of the image, minus any library prefix, and including the cell-location prefix if known
        /// </summary>
        public string FileName
        {
            get
            {
                if (ImageType == CellImageType.Grid3x || ImageType == CellImageType.OtherSymbolLibrary)
                {
                    return __FileName;
                }
                else if (ImageType == CellImageType.CustomImage)
                {
                    return __FileName;
                }
                else
                {
                    return __EntryString;
                }
            }
        }
        public string SaveFileName
        {
            get
            {
                if (ImageType == CellImageType.CustomImage)
                {
                    if (Parent == null)
                    {
                        return __FileName; // will be just type extension (eg .jpg)
                    }
                    else
                    {
                        // prefix with x-y
                        return String.Format("{0}-{1}{2}", Parent.Column, Parent.Row, __FileName);
                    }
                }
                else
                {
                    return this.FileName;
                }
            }
        }

        public CellImage() { }

        /// <summary>
        /// Creates a new <see cref="CellImage"/> object
        /// </summary>
        /// <param name="parent">The cell to which the <see cref="CellImage"/> belongs</param>
        /// <param name="entryString">The string defining the content, as per the Grid3 spec ([library]identifier or .ext)</param>
        public CellImage(Cell parent, string entryString)
        {
            Parent = parent;
            EntryString = entryString;
        }

        /// <summary>
        /// Creates a new <see cref="CellImage"/> object
        /// </summary>
        /// <param name="parent">The cell to which the <see cref="CellImage"/> belongs</param>
        /// <param name="imageType">The type of <see cref="CellImage"/> to be created</param>
        /// <param name="symbolLibrary">The library from which the content is drawn, or a blank string if no library is used</param>
        /// <param name="fileName">The filename of the content, bearing in mind that [grid3x] files tend to have no extension, and custom files have only an extension</param>
        public CellImage(Cell parent, CellImageType imageType, string fileName, string symbolLibrary = "")
        {
            Parent = parent;
            ImageType = imageType;
            __SymbolLibrary = symbolLibrary;
            __FileName = fileName;
        }
    }
}
