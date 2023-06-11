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
    public class Command : XmlNodeBasic
    {
        /// <summary>
        /// Returns the ID of this command (usually indicating the resulting action)
        /// </summary>
        public string? ID
        {
            get
            {
                return GetAttributeValueOrNull("ID");
            }
            set
            {
                if (value == null)
                {
                    if (Attributes.ContainsKey("ID"))
                    {
                        Attributes.Remove("ID");
                    }
                }
                else
                {
                    SetAttributeValue("ID", value);
                }
            }
        }
    }
}
