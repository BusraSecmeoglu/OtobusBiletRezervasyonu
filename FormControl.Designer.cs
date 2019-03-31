namespace OtobusBiletRezervasyonu
{
    partial class FormControl
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
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBPlateNumber = new System.Windows.Forms.ListBox();
            this.lBSeatNumber = new System.Windows.Forms.ListBox();
            this.lBTrip = new System.Windows.Forms.ListBox();
            this.lBNameSurname = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(12, 79);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(69, 17);
            this.lblPlateNumber.TabIndex = 0;
            this.lblPlateNumber.Text = "Plaka No:";
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Location = new System.Drawing.Point(164, 79);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(73, 17);
            this.lblSeatNumber.TabIndex = 0;
            this.lblSeatNumber.Text = "Koltuk No:";
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Location = new System.Drawing.Point(323, 79);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(136, 17);
            this.lblTrip.TabIndex = 0;
            this.lblTrip.Text = "Sefer Kalkış -> Varış";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // lBPlateNumber
            // 
            this.lBPlateNumber.FormattingEnabled = true;
            this.lBPlateNumber.ItemHeight = 16;
            this.lBPlateNumber.Location = new System.Drawing.Point(12, 114);
            this.lBPlateNumber.Name = "lBPlateNumber";
            this.lBPlateNumber.Size = new System.Drawing.Size(120, 244);
            this.lBPlateNumber.TabIndex = 1;
            this.lBPlateNumber.SelectedIndexChanged += new System.EventHandler(this.lBPlateNumber_SelectedIndexChanged);
            // 
            // lBSeatNumber
            // 
            this.lBSeatNumber.FormattingEnabled = true;
            this.lBSeatNumber.ItemHeight = 16;
            this.lBSeatNumber.Location = new System.Drawing.Point(167, 114);
            this.lBSeatNumber.Name = "lBSeatNumber";
            this.lBSeatNumber.Size = new System.Drawing.Size(120, 244);
            this.lBSeatNumber.TabIndex = 1;
            // 
            // lBTrip
            // 
            this.lBTrip.FormattingEnabled = true;
            this.lBTrip.ItemHeight = 16;
            this.lBTrip.Location = new System.Drawing.Point(326, 114);
            this.lBTrip.Name = "lBTrip";
            this.lBTrip.Size = new System.Drawing.Size(202, 244);
            this.lBTrip.TabIndex = 1;
            // 
            // lBNameSurname
            // 
            this.lBNameSurname.FormattingEnabled = true;
            this.lBNameSurname.ItemHeight = 16;
            this.lBNameSurname.Location = new System.Drawing.Point(595, 114);
            this.lBNameSurname.Name = "lBNameSurname";
            this.lBNameSurname.Size = new System.Drawing.Size(120, 244);
            this.lBNameSurname.TabIndex = 1;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lBNameSurname);
            this.Controls.Add(this.lBTrip);
            this.Controls.Add(this.lBSeatNumber);
            this.Controls.Add(this.lBPlateNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.lblPlateNumber);
            this.Name = "FormControl";
            this.Text = "FormControl";
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBPlateNumber;
        private System.Windows.Forms.ListBox lBSeatNumber;
        private System.Windows.Forms.ListBox lBTrip;
        private System.Windows.Forms.ListBox lBNameSurname;
    }
}