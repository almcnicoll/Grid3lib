#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents an entry in the GridSet FileMap
    /// </summary>
    public class Entry : XmlNodeBasic
    {
        /// <summary>
        /// Returns the static filename at the root of the <see cref="FileMap"/> <see cref="Entry"/>
        /// </summary>
        public string? StaticFile
        {
            get
            {
                if (Attributes.ContainsKey("StaticFile"))
                {
                    return Attributes["StaticFile"];
                } else
                {
                    return null;
                }
            }
        }
    }
}
