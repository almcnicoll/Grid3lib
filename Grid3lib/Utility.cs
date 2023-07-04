using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Grid3lib
{
    /// <summary>
    /// Contains utility methods and functions for general use
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Creates a subfolder inside an existing root folder. The root folder must already exist. The subfolder may already exist.
        /// </summary>
        /// <param name="rootFolderPath">The path of the existing root folder</param>
        /// <param name="subFolderPath">The path of the subfolder to create. The subfolder may be nested multiple levels deep.</param>
        /// <exception cref="DirectoryNotFoundException">Thrown if the root folder does not already exist</exception>
        public static void CreateSubFolder(string rootFolderPath, string subFolderPath)
        {
            if (!Directory.Exists(rootFolderPath))
            {
                throw new DirectoryNotFoundException(String.Format("rootFolderPath must be an existing path - {0} not found", rootFolderPath));
            }
            Directory.CreateDirectory(Path.Combine(rootFolderPath, subFolderPath));
        }
    }
}
