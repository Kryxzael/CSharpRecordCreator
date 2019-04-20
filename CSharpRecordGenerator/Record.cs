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

        public bool UsesProperites { get; set; }
        public bool CreateStruct { get; set; }

        public const string IND = "    ";

        public Record(string name, bool usesProperties, bool createStruct)
        {
            Name = name;
            UsesProperites = usesProperties;
            CreateStruct = createStruct;
        }

        public string Generate()
        {
            StringBuilder s = new StringBuilder();

            s.AppendLine($"public {(CreateStruct ? "struct" : "class" )} {Name.NormalizeCaps(true)}");
            s.AppendLine($"{{");

            //Generate fields
            foreach (RecordField i in Fields)
            {
                s.AppendLine($"{IND}{i.ToSyntaxString(UsesProperites)}");
            }

            if (!CreateStruct || Fields.Any())
            {
                CreateConstructor(s);
            }            


            s.AppendLine($"}}");

            return s.ToString();
        }

        private void CreateConstructor(StringBuilder s)
        {
            s.AppendLine();
            s.Append($"{IND}public {Name.NormalizeCaps(true)}(");

            foreach (RecordField i in Fields)
            {
                s.Append($"{i.DataType} {i.Name.NormalizeCaps(false)},");
            }

            //Remove trailing comma
            if (s[s.Length - 1] == ',')
            {
                s.Remove(s.Length - 1, 1);
            }

            s.AppendLine(")");
            s.AppendLine($"{IND}{{");

            foreach (RecordField i in Fields)
            {
                s.AppendLine($"{IND}{IND}{i.Name.NormalizeCaps(true)} = {i.Name.NormalizeCaps(false)};");
            }

            s.AppendLine($"{IND}}}");
        }
    }
}
