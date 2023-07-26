using System;
using System.Collections.Generic;
using System.Text;

namespace XmlParsing
{
    /// <summary>
    /// Contains utility functions for XML handling
    /// </summary>
    public static class XmlUtility
    {
        /// <summary>
        /// For sorting <see cref="IXmlNode"/>s on ascending tag name
        /// </summary>
        public class SortTagNameAscendingHelper : IComparer<IXmlNode>
        {
            /// <summary>
            /// Sorts <see cref="IXmlNode"/>s based on their tag names
            /// </summary>
            /// <param name="x">The first <see cref="IXmlNode"/></param>
            /// <param name="y">The second <see cref="IXmlNode"/></param>
            /// <returns>-1, 0 or 1 depending on the comparison result</returns>
            public int Compare(IXmlNode x, IXmlNode y)
            {
                return String.Compare(x.TagName, y.TagName);
            }
        }

        /// <summary>
        /// Returns a <see cref="SortTagNameAscendingHelper"/> instance
        /// </summary>
        /// <returns>The <see cref="SortTagNameAscendingHelper"/> instance</returns>
        public static IComparer<IXmlNode> SortTagNameAscending() { return (IComparer<IXmlNode>)new SortTagNameAscendingHelper(); }
    }
}
