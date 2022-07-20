#nullable enable
using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib
{
    public class CommandParameter
    {
        // TODO - handle more complex parameters with <p><s><r></r></s></p> structure


        public string Key { get; set; }

        public string Value { get; set; }

        public List<string>? Data { get; set; } = null;

        public CommandParameter(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public CommandParameter(string key, string value, IEnumerable<string> data) : this(key, value)
        {
            this.Data = new List<string>();
            foreach (string s in data)
            {
                this.Data.Add(s);
            }
        }
    }
}
