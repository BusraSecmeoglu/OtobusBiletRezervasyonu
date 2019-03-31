namespace OtobusBiletRezervasyonu
{
    partial class FormPassenger
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
            this.rbGenderFamale = new System.Windows.Forms.RadioButton();
            this.rbGenderMale = new System.Windows.Forms.RadioButton();
            this.btnRecord = new System.Windows.Forms.Button();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPassengerSurname = new System.Windows.Forms.Label();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.lblIdentificationNumber = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblBirtday = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rbGenderFamale
            // 
            this.rbGenderFamale.AutoSize = true;
            this.rbGenderFamale.Checked = true;
            this.rbGenderFamale.Location = new System.Drawing.Point(600, 38);
            this.rbGenderFamale.Margin = new System.Windows.Forms.Padding(4);
            this.rbGenderFamale.Name = "rbGenderFamale";
            this.rbGenderFamale.Size = new System.Drawing.Size(75, 21);
            this.rbGenderFamale.TabIndex = 19;
            this.rbGenderFamale.TabStop = true;
            this.rbGenderFamale.Text = "Famale";
            this.rbGenderFamale.UseVisualStyleBackColor = true;
            // 
            // rbGenderMale
            // 
            this.rbGenderMale.AutoSize = true;
            this.rbGenderMale.Location = new System.Drawing.Point(474, 40);
            this.rbGenderMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbGenderMale.Name = "rbGenderMale";
            this.rbGenderMale.Size = new System.Drawing.Size(59, 21);
            this.rbGenderMale.TabIndex = 18;
            this.rbGenderMale.TabStop = true;
            this.rbGenderMale.Text = "Male";
            this.rbGenderMale.UseVisualStyleBackColor = true;
            this.rbGenderMale.Click += new System.EventHandler(this.rbGenderMale_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(600, 147);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(100, 28);
            this.btnRecord.TabIndex = 20;
            this.btnRecord.Text = "Satın al";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(144, 83);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(132, 22);
            this.txtLastname.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(144, 42);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtFirstName.TabIndex = 8;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(367, 42);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 17);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Cinsiyet:";
            // 
            // lblPassengerSurname
            // 
            this.lblPassengerSurname.AutoSize = true;
            this.lblPassengerSurname.Location = new System.Drawing.Point(22, 83);
            this.lblPassengerSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassengerSurname.Name = "lblPassengerSurname";
            this.lblPassengerSurname.Size = new System.Drawing.Size(73, 17);
            this.lblPassengerSurname.TabIndex = 12;
            this.lblPassengerSurname.Text = "Soyadınız:";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(22, 42);
            this.lblPassengerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(50, 17);
            this.lblPassengerName.TabIndex = 13;
            this.lblPassengerName.Text = "Adınız:";
            // 
            // lblIdentificationNumber
            // 
            this.lblIdentificationNumber.AutoSize = true;
            this.lblIdentificationNumber.Location = new System.Drawing.Point(22, 144);
            this.lblIdentificationNumber.Name = "lblIdentificationNumber";
            this.lblIdentificationNumber.Size = new System.Drawing.Size(52, 17);
            this.lblIdentificationNumber.TabIndex = 22;
            this.lblIdentificationNumber.Text = "TC No:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(22, 194);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(80, 17);
            this.lblPhoneNumber.TabIndex = 22;
            this.lblPhoneNumber.Text = "Numaranız:";
            // 
            // lblBirtday
            // 
            this.lblBirtday.AutoSize = true;
            this.lblBirtday.Location = new System.Drawing.Point(22, 250);
            this.lblBirtday.Name = "lblBirtday";
            this.lblBirtday.Size = new System.Drawing.Size(116, 17);
            this.lblBirtday.TabIndex = 22;
            this.lblBirtday.Text = "Doğum gününüz:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(144, 139);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(132, 22);
            this.txtTC.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(144, 194);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FormPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 320);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblBirtday);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblIdentificationNumber);
            this.Controls.Add(this.rbGenderFamale);
            this.Controls.Add(this.rbGenderMale);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPassengerSurname);
            this.Controls.Add(this.lblPassengerName);
            this.Name = "FormPassenger";
            this.Text = "FormPassenger";
            this.Load += new System.EventHandler(this.FormPassenger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbGenderFamale;
        private System.Windows.Forms.RadioButton rbGenderMale;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPassengerSurname;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.Label lblIdentificationNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblBirtday;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}