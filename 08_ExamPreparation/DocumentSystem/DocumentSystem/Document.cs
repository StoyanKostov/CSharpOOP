using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    abstract class Document : IDocument
    {
        public string Name { get; protected set; }
        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString() // XXXDocument[key1=value1;key2=value2;…]
        {
            IList<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(properties);
            var orderedProperties = properties.OrderBy(property => property.Key);
            StringBuilder sb = new StringBuilder();
            sb.Append(this.GetType().Name);
            sb.Append("[");
            foreach (var property in orderedProperties)
	        {
                if (property.Value != null)
                {
                    sb.Append(property.Key);
                    sb.Append("=");
                    sb.Append(property.Value);
                    sb.Append(";");
                }
	        }
            sb.ToString().Substring(0, sb.Length - 1);
            return sb.ToString().Substring(0, sb.Length - 1) + "]";
        }
    }
}
