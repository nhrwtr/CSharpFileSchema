using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileSchema.Data
{
    public class Field
    {
        [XmlAttribute("name")]
        public string Name { get; set; } = "";
        [XmlIgnore]
        public int? Order { get; set; } = 0;
        [XmlAttribute("order")]
        public string OrderAsText
        {
            get { return Order.HasValue ? Order.ToString() : null; }
            set { Order = !string.IsNullOrEmpty(value) ? int.Parse(value) : default(int?); }
        }
        [XmlText]
        public string Text { get; set; } = "";

        public override string ToString()
        {
            return $"name='{Name}', order='{Order}', text='{Text}';";
        }
    }
}
