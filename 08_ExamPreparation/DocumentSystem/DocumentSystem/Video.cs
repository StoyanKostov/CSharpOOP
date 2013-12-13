using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    class Video : Multimedia
    {
        public uint? FrameRate { get; set; } // in fps

        // Extend base methods
        public override void LoadProperty(string key, string value)
        {
            if (key == "framerate")
            {
                this.FrameRate = uint.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
            base.SaveAllProperties(output);
        }
    }
}
