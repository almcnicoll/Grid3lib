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

        /// <summary>
        /// Creates a new Command
        /// </summary>
        public Command()
        {

        }

        /// <summary>
        /// Creates a new <see cref="Command"/> with the specified ID
        /// </summary>
        /// <param name="ID">The ID (action) of the <see cref="Command"/></param>
        public Command(string ID)
        {
            this.ID = ID;
        }

        /// <summary>
        /// Creates a new <see cref="Command"/> with the specified ID and parameters
        /// </summary>
        /// <param name="ID">The ID (action) of the <see cref="Command"/></param>
        /// <param name="Parameters">An <see cref="IEnumerable{T}"/> containing <see cref="KeyValuePair{TKey, TValue}"/> where Key and Value are both of type <see cref="string"/></param>
        public Command(string ID, IEnumerable<KeyValuePair<string, string>> Parameters)
        {
            this.ID = ID;
            foreach (KeyValuePair<string, string> kvp in Parameters)
            {
                Parameter parameter = AddChildOfType<Parameter>();
                parameter.Key = kvp.Key;
                parameter.Value = kvp.Value;
            }
        }
    }
}
