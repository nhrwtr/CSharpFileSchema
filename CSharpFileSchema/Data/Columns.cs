using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileSchema.Data
{
    [XmlType("columns")]
    [Serializable]
    public class Columns
    {
        [XmlAttribute("prefix")]
        public string Prefix { get; set; } = "";

        [XmlElement("field")]
        public List<Field> Fields { get; set; } = [];

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"prefix='{Prefix}'\n");
            sb.AppendLine("fields:");
            sb.AppendLine(string.Join("\n", Fields?.Select(e => e.ToString())));
            return sb.ToString();
        }
    }
}
