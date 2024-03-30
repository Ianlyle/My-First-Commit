namespace FinalProject
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.BtnReserve = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtTime2 = new System.Windows.Forms.TextBox();
            this.TxtTime1 = new System.Windows.Forms.TextBox();
            this.DatePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.CmbRoom1 = new System.Windows.Forms.ComboBox();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // BtnReserve
            // 
            this.BtnReserve.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReserve.Location = new System.Drawing.Point(957, 405);
            this.BtnReserve.Name = "BtnReserve";
            this.BtnReserve.Size = new System.Drawing.Size(109, 37);
            this.BtnReserve.TabIndex = 35;
            this.BtnReserve.Text = "Reserve Now";
            this.BtnReserve.UseVisualStyleBackColor = true;
            this.BtnReserve.Click += new System.EventHandler(this.BtnReserve_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBack.BackgroundImage")));
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.Location = new System.Drawing.Point(12, 9);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(47, 32);
            this.BtnBack.TabIndex = 34;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.Location = new System.Drawing.Point(691, 405);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(145, 37);
            this.BtnGenerate.TabIndex = 33;
            this.BtnGenerate.Text = "Generate Receipt";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResult.Location = new System.Drawing.Point(709, 15);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(358, 377);
            this.TxtResult.TabIndex = 31;
            this.TxtResult.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.TxtTime2);
            this.groupBox1.Controls.Add(this.TxtTime1);
            this.groupBox1.Controls.Add(this.DatePicker2);
            this.groupBox1.Controls.Add(this.DatePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LblPrice);
            this.groupBox1.Controls.Add(this.CmbRoom1);
            this.groupBox1.Controls.Add(this.TxtNumber);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 232);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill Up Here";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Time Check out:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Time Check in:";
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.Black;
            this.BtnReset.Location = new System.Drawing.Point(587, 189);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 26;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TxtTime2
            // 
            this.TxtTime2.Location = new System.Drawing.Point(587, 132);
            this.TxtTime2.Name = "TxtTime2";
            this.TxtTime2.Size = new System.Drawing.Size(73, 26);
            this.TxtTime2.TabIndex = 21;
            // 
            // TxtTime1
            // 
            this.TxtTime1.Location = new System.Drawing.Point(587, 62);
            this.TxtTime1.Name = "TxtTime1";
            this.TxtTime1.Size = new System.Drawing.Size(73, 26);
            this.TxtTime1.TabIndex = 21;
            // 
            // DatePicker2
            // 
            this.DatePicker2.Location = new System.Drawing.Point(344, 129);
            this.DatePicker2.Name = "DatePicker2";
            this.DatePicker2.Size = new System.Drawing.Size(213, 26);
            this.DatePicker2.TabIndex = 20;
            // 
            // DatePicker1
            // 
            this.DatePicker1.Location = new System.Drawing.Point(344, 59);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(213, 26);
            this.DatePicker1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Price:";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(236, 135);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(48, 18);
            this.LblPrice.TabIndex = 17;
            this.LblPrice.Text = "000.0";
            // 
            // CmbRoom1
            // 
            this.CmbRoom1.FormattingEnabled = true;
            this.CmbRoom1.Items.AddRange(new object[] {
            "Deluxe",
            "Premium",
            "Executive"});
            this.CmbRoom1.Location = new System.Drawing.Point(16, 127);
            this.CmbRoom1.Name = "CmbRoom1";
            this.CmbRoom1.Size = new System.Drawing.Size(121, 26);
            this.CmbRoom1.TabIndex = 16;
            this.CmbRoom1.SelectedIndexChanged += new System.EventHandler(this.CmbRoom1_SelectedIndexChanged);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(16, 189);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(96, 26);
            this.TxtNumber.TabIndex = 6;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(16, 54);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(242, 26);
            this.TxtName.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(425, 189);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(336, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Check Out: Day/Month/Year";
            // 
            // BtnDelete
            // 
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(506, 190);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(336, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Check In: Day/Month/Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(13, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number of Occupancy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Room Type Ex. Deluxe,Premium,Executive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Location = new System.Drawing.Point(842, 405);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(109, 37);
            this.BtnPrint.TabIndex = 32;
            this.BtnPrint.Text = "Print Receipt";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // DataGrid1
            // 
            this.DataGrid1.Location = new System.Drawing.Point(71, 285);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(570, 150);
            this.DataGrid1.TabIndex = 29;
            this.DataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid1_CellContentClick);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.BtnReserve);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.DataGrid1);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button BtnReserve;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.RichTextBox TxtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TxtTime2;
        private System.Windows.Forms.TextBox TxtTime1;
        private System.Windows.Forms.DateTimePicker DatePicker2;
        private System.Windows.Forms.DateTimePicker DatePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.ComboBox CmbRoom1;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridView DataGrid1;
    }
}