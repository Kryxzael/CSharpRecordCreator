using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecordGenerator
{
    public class RecordField
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public bool ReadOnly { get; set; }

        public RecordField(string dataType, string name, bool readOnly)
        {
            DataType = dataType;
            Name = name;
            ReadOnly = readOnly;
        }

        public string ToSyntaxString(bool usesProperites)
        {
            if (usesProperites)
            {
                return $"public {DataType} {Name.NormalizeCaps(true)} {{ get; {(ReadOnly ? "" : "set; ")}}}";
            }

            return $"public {(ReadOnly ? "readonly " : "")}{DataType} {Name.NormalizeCaps(true)};";
        }
    }
}
