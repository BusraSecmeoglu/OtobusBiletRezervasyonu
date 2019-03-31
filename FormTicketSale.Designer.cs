namespace OtobusBiletRezervasyonu
{
    partial class FormTicketSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicketSale));
            this.cBBuses = new System.Windows.Forms.ComboBox();
            this.cBDepartureCities = new System.Windows.Forms.ComboBox();
            this.cBArrivalCities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pSeats = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDeperature = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBBuses
            // 
            this.cBBuses.FormattingEnabled = true;
            this.cBBuses.Location = new System.Drawing.Point(19, 76);
            this.cBBuses.Margin = new System.Windows.Forms.Padding(4);
            this.cBBuses.Name = "cBBuses";
            this.cBBuses.Size = new System.Drawing.Size(160, 24);
            this.cBBuses.TabIndex = 0;
            this.cBBuses.SelectedIndexChanged += new System.EventHandler(this.cBBuses_SelectedIndexChanged);
            // 
            // cBDepartureCities
            // 
            this.cBDepartureCities.FormattingEnabled = true;
            this.cBDepartureCities.Location = new System.Drawing.Point(338, 76);
            this.cBDepartureCities.Margin = new System.Windows.Forms.Padding(4);
            this.cBDepartureCities.Name = "cBDepartureCities";
            this.cBDepartureCities.Size = new System.Drawing.Size(160, 24);
            this.cBDepartureCities.TabIndex = 0;
            this.cBDepartureCities.SelectedIndexChanged += new System.EventHandler(this.cBDepartureCities_SelectedIndexChanged);
            // 
            // cBArrivalCities
            // 
            this.cBArrivalCities.FormattingEnabled = true;
            this.cBArrivalCities.Location = new System.Drawing.Point(658, 76);
            this.cBArrivalCities.Margin = new System.Windows.Forms.Padding(4);
            this.cBArrivalCities.Name = "cBArrivalCities";
            this.cBArrivalCities.Size = new System.Drawing.Size(160, 24);
            this.cBArrivalCities.TabIndex = 0;
            this.cBArrivalCities.SelectedIndexChanged += new System.EventHandler(this.cBArrivalCities_SelectedIndexChanged);
            this.cBArrivalCities.ValueMemberChanged += new System.EventHandler(this.CBArrivalCities_ValueMemberChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kalkış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Varış";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Koltuklar";
            // 
            // pSeats
            // 
            this.pSeats.Location = new System.Drawing.Point(569, 219);
            this.pSeats.Margin = new System.Windows.Forms.Padding(4);
            this.pSeats.Name = "pSeats";
            this.pSeats.Size = new System.Drawing.Size(310, 234);
            this.pSeats.TabIndex = 2;
            this.pSeats.Click += new System.EventHandler(this.pSeats_Click);
            this.pSeats.Paint += new System.Windows.Forms.PaintEventHandler(this.pSeats_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerDeperature);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pSeats);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBBuses);
            this.groupBox1.Controls.Add(this.cBArrivalCities);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBDepartureCities);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 475);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet için seçimleri yapınız";
            // 
            // dateTimePickerDeperature
            // 
            this.dateTimePickerDeperature.Location = new System.Drawing.Point(338, 125);
            this.dateTimePickerDeperature.Name = "dateTimePickerDeperature";
            this.dateTimePickerDeperature.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDeperature.TabIndex = 6;
            this.dateTimePickerDeperature.ValueChanged += new System.EventHandler(this.dateTimePickerDeperature_ValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(409, 252);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(409, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Aracınız:";
            // 
            // FormTicketSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 524);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTicketSale";
            this.Text = "FormTicketSale";
            this.Load += new System.EventHandler(this.FormTicketSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBBuses;
        private System.Windows.Forms.ComboBox cBDepartureCities;
        private System.Windows.Forms.ComboBox cBArrivalCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pSeats;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeperature;
    }
}