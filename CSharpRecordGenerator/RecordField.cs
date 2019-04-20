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

        public RecordField(string dataType, string name)
        {
            DataType = dataType;
            Name = name;
        }

        public string ToSyntaxString(bool usesProperites)
        {
            if (usesProperites)
            {
                return $"public {DataType} {Name} {{ get; set; }}";
            }

            return $"public {DataType} {Name};";
        }
    }
}
