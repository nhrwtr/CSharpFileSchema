using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileSchema.Data
{
    [XmlRoot("file")]
    public class FileConfig
    {
        [XmlAttribute("type")]
        public string FileType { get; set; } = "tsv";

        [XmlAttribute("delimiter")]
        public string Delimiter { get; set; } = "\t";

        [XmlElement("header")]
        public Header Header { get; set; } = new();

        [XmlElement("columns")]
        public Columns Columns { get; set; } = new();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"type='{FileType}', delimiter='{Delimiter}'\n");
            sb.AppendLine("header:");
            sb.AppendLine(Header?.ToString());
            sb.AppendLine("columns: ");
            sb.AppendLine(Columns?.ToString());
            return sb.ToString();
        }
    }
}
