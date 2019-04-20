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
        public bool CreateEqualityOperators { get; set; }

        public const string IND = "    ";

        public Record(string name, bool usesProperties, bool createStruct, bool createEqualityChecks)
        {
            Name = name;
            UsesProperites = usesProperties;
            CreateStruct = createStruct;
            CreateEqualityOperators = createEqualityChecks;
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

            if (CreateEqualityOperators && Fields.Any())
            {
                GenerateEqualityOperators(s);
            }
            


            s.AppendLine($"}}");

            return s.ToString();
        }

        private void CreateConstructor(StringBuilder s)
        {
            s.AppendLine();
            s.AppendLine($"{IND}public {Name.NormalizeCaps(true)}({string.Join(", ", Fields.Select(i => $"{i.DataType} {i.Name.NormalizeCaps(false)}"))})");
            s.AppendLine($"{IND}{{");

            foreach (RecordField i in Fields)
            {
                s.AppendLine($"{IND}{IND}{i.Name.NormalizeCaps(true)} = {i.Name.NormalizeCaps(false)};");
            }

            s.AppendLine($"{IND}}}");
        }

        private void GenerateEqualityOperators(StringBuilder s)
        {
            s.AppendLine();

            //==
            s.AppendLine($"{IND}public static bool operator ==({Name.NormalizeCaps(true)} left, {Name.NormalizeCaps(true)} right)");
            s.AppendLine($"{IND}{{");
            s.AppendLine($"{IND}{IND}return {string.Join(" && ", Fields.Select(i => $"left.{i.Name.NormalizeCaps(true)} == right.{i.Name.NormalizeCaps(true)}"))};");
            s.AppendLine($"{IND}}}");
            s.AppendLine();

            //!=
            s.AppendLine($"{IND}public static bool operator !=({Name.NormalizeCaps(true)} left, {Name.NormalizeCaps(true)} right)");
            s.AppendLine($"{IND}{{");
            s.AppendLine($"{IND}{IND}return !(left == right);");
            s.AppendLine($"{IND}}}");
            s.AppendLine();

            //Equals()
            s.AppendLine($"{IND}public override bool Equals(object obj)");
            s.AppendLine($"{IND}{{");
            s.AppendLine($"{IND}{IND}if (obj is {Name.NormalizeCaps(true)})");
            s.AppendLine($"{IND}{IND}{{");
            s.AppendLine($"{IND}{IND}{IND}return ({Name.NormalizeCaps(true)})obj == this;");
            s.AppendLine($"{IND}{IND}}}");
            s.AppendLine($"{IND}{IND}");
            s.AppendLine($"{IND}{IND}return false;");
            s.AppendLine($"{IND}}}");
            s.AppendLine();

            //GetHashCode()
            s.AppendLine($"{IND}public override int GetHashCode()");
            s.AppendLine($"{IND}{{");
            s.AppendLine($"{IND}{IND}return {string.Join(" ^ ", Fields.Select(i => i.Name.NormalizeCaps(true) + ".GetHashCode()")) };");
            s.AppendLine($"{IND}}}");
        }
    }
}
