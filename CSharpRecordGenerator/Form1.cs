using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace CSharpRecordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnClickGenerate(object sender, EventArgs e)
        {
            txtOutput.Text = GenerateRecord().Generate();
        }

        private Record GenerateRecord()
        {
            Record r = new Record(txtRecName.Text, chkProp.Checked, chkStruct.Checked, chkEquality.Checked);

            foreach (DataGridViewRow i in data.Rows)
            {
                if (i.IsNewRow)
                {
                    continue;
                }

                r.Fields.Add(new RecordField(
                    dataType: i.Cells[0].Value.ToString(),
                    name: i.Cells[1].Value.ToString(),
                    readOnly: true.Equals(i.Cells[2].Value)
                ));
            }


            return r;
        }
    }
}
