using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecordGenerator
{
    public class Record
    {
        public string Name { get; set; }
        public List<RecordField> Fields { get; } = new List<RecordField>();

        public const string IND = "    ";

        public Record(string name)
        {
            Name = name;
        }

        public string Generate()
        {
            StringBuilder s = new StringBuilder();

            s.AppendLine($"public class {Name}");
            s.AppendLine($"{{");

            //Generate fields
            foreach (RecordField i in Fields)
            {
                s.AppendLine($"{IND}{i.ToSyntaxString()}");
            }

            s.AppendLine($"}}");

            return s.ToString();
        }
    }
}
