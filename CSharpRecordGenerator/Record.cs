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
        public List<dynamic> Fields { get; } = new List<dynamic>();
    }
}
