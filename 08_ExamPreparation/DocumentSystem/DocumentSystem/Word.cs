using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    class Word : OfficeDocument, IEditable
    {
        public uint? NumberOfCharacters { get; set; }

        // IEditable implementation
        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        // Extend base methods
        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.NumberOfCharacters = uint.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
            base.SaveAllProperties(output);
        }
    }
}
