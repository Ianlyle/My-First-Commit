namespace FinalProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BtnHotel = new System.Windows.Forms.Button();
            this.BtnResort = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHotel
            // 
            this.BtnHotel.BackColor = System.Drawing.Color.White;
            this.BtnHotel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHotel.BackgroundImage")));
            this.BtnHotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHotel.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHotel.ForeColor = System.Drawing.Color.White;
            this.BtnHotel.Location = new System.Drawing.Point(78, 77);
            this.BtnHotel.Name = "BtnHotel";
            this.BtnHotel.Size = new System.Drawing.Size(312, 81);
            this.BtnHotel.TabIndex = 0;
            this.BtnHotel.Text = "HOTELS";
            this.BtnHotel.UseVisualStyleBackColor = false;
            this.BtnHotel.Click += new System.EventHandler(this.BtnHotel_Click);
            // 
            // BtnResort
            // 
            this.BtnResort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnResort.BackgroundImage")));
            this.BtnResort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnResort.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResort.ForeColor = System.Drawing.Color.White;
            this.BtnResort.Location = new System.Drawing.Point(78, 185);
            this.BtnResort.Name = "BtnResort";
            this.BtnResort.Size = new System.Drawing.Size(312, 81);
            this.BtnResort.TabIndex = 1;
            this.BtnResort.Text = "RESORTS";
            this.BtnResort.UseVisualStyleBackColor = true;
            this.BtnResort.Click += new System.EventHandler(this.BtnResort_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Black;
            this.BtnBack.Location = new System.Drawing.Point(188, 335);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(79, 28);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Return";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 375);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnResort);
            this.Controls.Add(this.BtnHotel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHotel;
        private System.Windows.Forms.Button BtnResort;
        private System.Windows.Forms.Button BtnBack;
    }
}