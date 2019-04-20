namespace CSharpRecordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.data = new System.Windows.Forms.DataGridView();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReadOnly = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkEquality = new System.Windows.Forms.CheckBox();
            this.chkStruct = new System.Windows.Forms.CheckBox();
            this.chkProp = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtRecName = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCopyAll);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Size = new System.Drawing.Size(726, 292);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.data);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chkEquality);
            this.splitContainer2.Panel2.Controls.Add(this.chkStruct);
            this.splitContainer2.Panel2.Controls.Add(this.chkProp);
            this.splitContainer2.Panel2.Controls.Add(this.lblName);
            this.splitContainer2.Panel2.Controls.Add(this.txtRecName);
            this.splitContainer2.Panel2.Controls.Add(this.btnGen);
            this.splitContainer2.Size = new System.Drawing.Size(382, 292);
            this.splitContainer2.SplitterDistance = 211;
            this.splitContainer2.TabIndex = 1;
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmType,
            this.clmName,
            this.clmReadOnly});
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(382, 211);
            this.data.TabIndex = 0;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "Data Type";
            this.clmType.Name = "clmType";
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Identifier";
            this.clmName.Name = "clmName";
            // 
            // clmReadOnly
            // 
            this.clmReadOnly.HeaderText = "ROnly";
            this.clmReadOnly.Name = "clmReadOnly";
            this.clmReadOnly.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmReadOnly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmReadOnly.Width = 50;
            // 
            // chkEquality
            // 
            this.chkEquality.AutoSize = true;
            this.chkEquality.Location = new System.Drawing.Point(151, 3);
            this.chkEquality.Name = "chkEquality";
            this.chkEquality.Size = new System.Drawing.Size(159, 17);
            this.chkEquality.TabIndex = 5;
            this.chkEquality.Text = "Generate Equality Operators";
            this.chkEquality.UseVisualStyleBackColor = true;
            // 
            // chkStruct
            // 
            this.chkStruct.AutoSize = true;
            this.chkStruct.Location = new System.Drawing.Point(3, 26);
            this.chkStruct.Name = "chkStruct";
            this.chkStruct.Size = new System.Drawing.Size(54, 17);
            this.chkStruct.TabIndex = 4;
            this.chkStruct.Text = "Struct";
            this.chkStruct.UseVisualStyleBackColor = true;
            // 
            // chkProp
            // 
            this.chkProp.AutoSize = true;
            this.chkProp.Checked = true;
            this.chkProp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProp.Location = new System.Drawing.Point(3, 3);
            this.chkProp.Name = "chkProp";
            this.chkProp.Size = new System.Drawing.Size(142, 17);
            this.chkProp.TabIndex = 3;
            this.chkProp.Text = "Generate with Properties";
            this.chkProp.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(118, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtRecName
            // 
            this.txtRecName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecName.Location = new System.Drawing.Point(159, 53);
            this.txtRecName.Name = "txtRecName";
            this.txtRecName.Size = new System.Drawing.Size(142, 20);
            this.txtRecName.TabIndex = 1;
            this.txtRecName.Text = "Program";
            // 
            // btnGen
            // 
            this.btnGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGen.Location = new System.Drawing.Point(307, 51);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.OnClickGenerate);
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyAll.Location = new System.Drawing.Point(262, 266);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(75, 23);
            this.btnCopyAll.TabIndex = 1;
            this.btnCopyAll.Text = "Copy All";
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.OnCopyAllClicked);
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(340, 292);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "[[OUTPUT]]";
            this.txtOutput.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 292);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(528, 331);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtRecName;
        private System.Windows.Forms.CheckBox chkProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmReadOnly;
        private System.Windows.Forms.CheckBox chkStruct;
        private System.Windows.Forms.CheckBox chkEquality;
    }
}

