﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    abstract class Multimedia : BinaryDoc
    {
        public uint? Length { get; set; }

        // Extend base methods
        public override void LoadProperty(string key, string value)
        {
            if (key == "length")
            {
                this.Length = uint.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("length", this.Length));
            base.SaveAllProperties(output);
        }
    }
}
