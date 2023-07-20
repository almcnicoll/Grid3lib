using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a parameter relating to a <see cref="Command"/>
    /// </summary>
    public class Parameter : XmlNodeBasic
    {
        public string? Key
        {
            get
            {
                if (__Attributes.ContainsKey("Key"))
                {
                    return __Attributes["Key"];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value == null)
                {
                    __Attributes.Remove("Key");
                }
                else
                {
                    __Attributes.AddOrEdit("Key", value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the value of the <see cref="Parameter"/>
        /// </summary>
        public string? Value
        {
            get
            {
                return InnerXmlString;
            }
            set
            {
                InnerXml = new List<RawXml>();
                if (value != null)
                {
                    InnerXml.Add(new RawXml(value));
                }
            }
        }
    }
}
