#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Filters a list of file paths to give the ones which match the provided pattern
        /// </summary>
        /// <param name="filter">The regular expression used to filter the list</param>
        /// <param name="paths">The source list of file paths</param>
        /// <returns>A list of file paths which match the pattern</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static List<FileInfo> getMatchingFiles(Regex filter, List<FileInfo> paths)
        {
            if (paths == null) { throw new ArgumentNullException(nameof(paths)); }
            if (filter == null) { throw new ArgumentNullException(nameof(filter)); }
            return (from FileInfo fi in paths where filter.IsMatch(fi.FullName) select fi).ToList();
        }
        /// <summary>
        /// Filters a list of file paths to give the ones which match the provided pattern
        /// </summary>
        /// <param name="filter">The regular expression used to filter the list</param>
        /// <param name="paths">The source list of file paths</param>
        /// <returns>A list of file paths which match the pattern</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static List<string> getMatchingFiles(Regex filter, List<string> paths)
        {
            if (paths == null) { throw new ArgumentNullException(nameof(paths)); }
            if (filter == null) { throw new ArgumentNullException(nameof(filter)); }
            return (from string path in paths where filter.IsMatch(path) select path).ToList();
        }

        /// <summary>
        /// Filters a list of file paths to give the ones which match the provided pattern
        /// </summary>
        /// <param name="wildcard">The filename wildcard used to filter the list</param>
        /// <param name="paths">The source list of file paths</param>
        /// <returns>A list of file paths which match the pattern</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static List<FileInfo> getMatchingFiles(string wildcard, List<FileInfo> paths)
        {
            if (paths == null) { throw new ArgumentNullException(nameof(paths)); }
            if (wildcard == null) { throw new ArgumentNullException(nameof(wildcard)); }
            Regex filter = RegexFromWildcard(wildcard);
            return (from FileInfo fi in paths where filter.IsMatch(fi.FullName) select fi).ToList();
        }
        /// <summary>
        /// Filters a list of file paths to give the ones which match the provided pattern
        /// </summary>
        /// <param name="wildcard">The filename wildcard used to filter the list</param>
        /// <param name="paths">The source list of file paths</param>
        /// <returns>A list of file paths which match the pattern</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static List<string> getMatchingFiles(string wildcard, List<string> paths)
        {
            if (paths == null) { throw new ArgumentNullException(nameof(paths)); }
            if (wildcard == null) { throw new ArgumentNullException(nameof(wildcard)); }
            Regex filter = RegexFromWildcard(wildcard);
            return (from string path in paths where filter.IsMatch(path) select path).ToList();
        }

        /// <summary>
        /// Returns a regular expression from a file wildcard
        /// </summary>
        /// <param name="wildcard">The file pattern to use</param>
        /// <returns>A regular expression equivalent to the file wildcard</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if the wildcard supplied is null</exception>
        public static Regex RegexFromWildcard(string wildcard)
        {
            if (wildcard == null) { throw new System.ArgumentNullException("wildcard"); }
            string pattern = wildcard.Replace(@".", @"\.").Replace(@"*", @".*").Replace(@"?", @".?");
            Regex fromWildcard = new Regex("^" + pattern + "$");
            return fromWildcard;
        }

        /// <summary>
        /// Changes the direction of backslashes in the specified file path, and optionally strips out a root folder if specified
        /// </summary>
        /// <param name="path">The path to make relative</param>
        /// <param name="rootFolder">A root folder to strip from the start of the path before making it relative</param>
        public static string makeRelativePath(string path, string? rootFolder = null)
        {
            if (rootFolder != null)
            {
                if (path.StartsWith(rootFolder)) { path = path.Substring(rootFolder.Length); }
                if (path.StartsWith(@"\")) { path = path.Substring(1); }
            }
            Regex slashChanger = new Regex(@"\\");

            return slashChanger.Replace(path, "/");
        }
    }
}
