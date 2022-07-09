using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib
{
    /// <summary>
    /// Represents a command that can be attached to a cell or Page
    /// </summary>
    public class Command
    {
        public string Action { get; set; }
        public List<KeyValuePair<string, string>> Parameters { get; set; } = new List<KeyValuePair<string, string>>();
    }
}
