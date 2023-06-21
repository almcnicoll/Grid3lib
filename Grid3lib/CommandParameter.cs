#nullable enable
using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ToConvert
{
    public class CommandParameter
    {
        // TODO - LOW PRIORITY handle more complex parameters with <p><s><r></r></s></p> structure


        public string Key { get; set; }

        private RichText __Value;

        public string Value
        {
            get { return __Value.ToString(); }
        }

        public RichText RichValue
        {
            get { return __Value; }
            set { __Value = value; }
        }

        public List<string>? Data { get; set; } = null;

        public CommandParameter(string key, string value)
        {
            this.Key = key;
            __Value = new RichText(value);
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
