using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a Gridset
    /// </summary>
    public class Gridset : XmlNodeBasic
    {
        /// <summary>
        /// Fills the XML node from the specified XML markup
        /// </summary>
        /// <param name="Xml">The source XML</param>
        /// <param name="PopulateChildren">Whether to populate the child nodes also</param>
        public override void PopulateFromXml(string Xml, bool PopulateChildren = true)
        {
            // Always call base method to populate basic properties
            base.PopulateFromXml(Xml, PopulateChildren);

            //TODO - extra property setting here
        }
    }
}
