using System;
using System.Collections.Generic;
using System.Text;

namespace XmlParsing
{
    /// <summary>
    /// Represents an XML node in its unprocessed form, with metadata
    /// </summary>
    public class RawXml
    {
        /// <summary>
        /// Contains the XML markup itself
        /// </summary>
        public string Markup { get; set; } = "";

        /// <summary>
        /// Indicates whether this XML has been parsed/processed
        /// </summary>
        public bool Parsed { get; set; } = false;

        /// <summary>
        /// References the IXmlNode attached to this markup
        /// </summary>
        public IXmlNode? Node { get; set; } = null;

        public RawXml() { }

        /// <summary>
        /// Constructs a new RawXml object with the specified parameters
        /// </summary>
        /// <param name="Markup">The XML markup itself</param>
        /// <param name="Parsed">Whether the XML has been parsed/processed</param>
        public RawXml(string Markup, bool Parsed = false)
        {
            this.Markup = Markup;
            this.Parsed = Parsed;
        }

        /// <summary>
        /// Returns the XML markup of the <see cref="RawXml"/> node
        /// </summary>
        /// <returns>A string containing XML markup</returns>
        public override string ToString()
        {
            return Markup;
        }
    }
}
