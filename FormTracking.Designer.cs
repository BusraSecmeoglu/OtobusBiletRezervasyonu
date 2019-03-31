namespace OtobusBiletRezervasyonu
{
    partial class FormTracking
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
            this.btnBusStateSave = new System.Windows.Forms.Button();
            this.btnDailyArchive = new System.Windows.Forms.Button();
            this.lstDailyRecordArchive = new System.Windows.Forms.ListBox();
            this.lstDate = new System.Windows.Forms.ListBox();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.lstPlate = new System.Windows.Forms.ListBox();
            this.txtPersonNumber = new System.Windows.Forms.TextBox();
            this.cbBuses = new System.Windows.Forms.ComboBox();
            this.btnBusAnimated = new System.Windows.Forms.Button();
            this.lblPersonNumber = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDailyRecord = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPlate = new System.Windows.Forms.Label();
            this.lblBus = new System.Windows.Forms.Label();
            this.cBTrip = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBusStateSave
            // 
            this.btnBusStateSave.Location = new System.Drawing.Point(36, 361);
            this.btnBusStateSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusStateSave.Name = "btnBusStateSave";
            this.btnBusStateSave.Size = new System.Drawing.Size(310, 52);
            this.btnBusStateSave.TabIndex = 22;
            this.btnBusStateSave.Text = "Araç Durum Kaydet";
            this.btnBusStateSave.UseVisualStyleBackColor = true;
            this.btnBusStateSave.Click += new System.EventHandler(this.btnBusStateSave_Click);
            // 
            // btnDailyArchive
            // 
            this.btnDailyArchive.Location = new System.Drawing.Point(1149, 30);
            this.btnDailyArchive.Margin = new System.Windows.Forms.Padding(4);
            this.btnDailyArchive.Name = "btnDailyArchive";
            this.btnDailyArchive.Size = new System.Drawing.Size(100, 34);
            this.btnDailyArchive.TabIndex = 21;
            this.btnDailyArchive.Text = "Günlük Arşiv";
            this.btnDailyArchive.UseVisualStyleBackColor = true;
            this.btnDailyArchive.Click += new System.EventHandler(this.DailyArchive_Click);
            // 
            // lstDailyRecordArchive
            // 
            this.lstDailyRecordArchive.FormattingEnabled = true;
            this.lstDailyRecordArchive.ItemHeight = 16;
            this.lstDailyRecordArchive.Location = new System.Drawing.Point(716, 74);
            this.lstDailyRecordArchive.Margin = new System.Windows.Forms.Padding(4);
            this.lstDailyRecordArchive.Name = "lstDailyRecordArchive";
            this.lstDailyRecordArchive.Size = new System.Drawing.Size(533, 212);
            this.lstDailyRecordArchive.TabIndex = 20;
            // 
            // lstDate
            // 
            this.lstDate.FormattingEnabled = true;
            this.lstDate.ItemHeight = 16;
            this.lstDate.Location = new System.Drawing.Point(211, 227);
            this.lstDate.Margin = new System.Windows.Forms.Padding(4);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(205, 116);
            this.lstDate.TabIndex = 19;
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.ItemHeight = 16;
            this.lstPrice.Location = new System.Drawing.Point(436, 227);
            this.lstPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(159, 116);
            this.lstPrice.TabIndex = 18;
            // 
            // lstPlate
            // 
            this.lstPlate.FormattingEnabled = true;
            this.lstPlate.ItemHeight = 16;
            this.lstPlate.Location = new System.Drawing.Point(36, 227);
            this.lstPlate.Margin = new System.Windows.Forms.Padding(4);
            this.lstPlate.Name = "lstPlate";
            this.lstPlate.Size = new System.Drawing.Size(159, 116);
            this.lstPlate.TabIndex = 17;
            this.lstPlate.SelectedIndexChanged += new System.EventHandler(this.lstPlate_SelectedIndexChanged);
            // 
            // txtPersonNumber
            // 
            this.txtPersonNumber.Enabled = false;
            this.txtPersonNumber.Location = new System.Drawing.Point(477, 51);
            this.txtPersonNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonNumber.Name = "txtPersonNumber";
            this.txtPersonNumber.Size = new System.Drawing.Size(112, 22);
            this.txtPersonNumber.TabIndex = 16;
            // 
            // cbBuses
            // 
            this.cbBuses.FormattingEnabled = true;
            this.cbBuses.Location = new System.Drawing.Point(36, 51);
            this.cbBuses.Margin = new System.Windows.Forms.Padding(4);
            this.cbBuses.Name = "cbBuses";
            this.cbBuses.Size = new System.Drawing.Size(134, 24);
            this.cbBuses.TabIndex = 14;
            this.cbBuses.SelectedIndexChanged += new System.EventHandler(this.cbBuses_SelectedIndexChanged);
            // 
            // btnBusAnimated
            // 
            this.btnBusAnimated.Location = new System.Drawing.Point(36, 111);
            this.btnBusAnimated.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusAnimated.Name = "btnBusAnimated";
            this.btnBusAnimated.Size = new System.Drawing.Size(149, 48);
            this.btnBusAnimated.TabIndex = 13;
            this.btnBusAnimated.Text = "Araç Hareketlendir";
            this.btnBusAnimated.UseVisualStyleBackColor = true;
            this.btnBusAnimated.Click += new System.EventHandler(this.btnBusAnimated_Click);
            // 
            // lblPersonNumber
            // 
            this.lblPersonNumber.AutoSize = true;
            this.lblPersonNumber.Location = new System.Drawing.Point(484, 30);
            this.lblPersonNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonNumber.Name = "lblPersonNumber";
            this.lblPersonNumber.Size = new System.Drawing.Size(71, 17);
            this.lblPersonNumber.TabIndex = 11;
            this.lblPersonNumber.Text = "Kişi Sayısı";
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Location = new System.Drawing.Point(212, 30);
            this.lblTrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(42, 17);
            this.lblTrip.TabIndex = 10;
            this.lblTrip.Text = "Sefer";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(432, 204);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(102, 17);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Toplam Hasılat";
            // 
            // lblDailyRecord
            // 
            this.lblDailyRecord.AutoSize = true;
            this.lblDailyRecord.Location = new System.Drawing.Point(716, 30);
            this.lblDailyRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDailyRecord.Name = "lblDailyRecord";
            this.lblDailyRecord.Size = new System.Drawing.Size(126, 17);
            this.lblDailyRecord.TabIndex = 8;
            this.lblDailyRecord.Text = "Günlük Kayıt Arşivi";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(207, 207);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Tarih";
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Location = new System.Drawing.Point(32, 204);
            this.lblPlate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(43, 17);
            this.lblPlate.TabIndex = 12;
            this.lblPlate.Text = "Plaka";
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Location = new System.Drawing.Point(37, 30);
            this.lblBus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(54, 17);
            this.lblBus.TabIndex = 6;
            this.lblBus.Text = "Otobüs";
            // 
            // cBTrip
            // 
            this.cBTrip.FormattingEnabled = true;
            this.cBTrip.Location = new System.Drawing.Point(214, 51);
            this.cBTrip.Name = "cBTrip";
            this.cBTrip.Size = new System.Drawing.Size(225, 24);
            this.cBTrip.TabIndex = 23;
            this.cBTrip.SelectedIndexChanged += new System.EventHandler(this.cBTrip_SelectedIndexChanged);
            // 
            // FormTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 440);
            this.Controls.Add(this.cBTrip);
            this.Controls.Add(this.btnBusStateSave);
            this.Controls.Add(this.btnDailyArchive);
            this.Controls.Add(this.lstDailyRecordArchive);
            this.Controls.Add(this.lstDate);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.lstPlate);
            this.Controls.Add(this.txtPersonNumber);
            this.Controls.Add(this.cbBuses);
            this.Controls.Add(this.btnBusAnimated);
            this.Controls.Add(this.lblPersonNumber);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDailyRecord);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.lblBus);
            this.Name = "FormTracking";
            this.Text = "FormTracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusStateSave;
        private System.Windows.Forms.Button btnDailyArchive;
        private System.Windows.Forms.ListBox lstDailyRecordArchive;
        private System.Windows.Forms.ListBox lstDate;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.ListBox lstPlate;
        private System.Windows.Forms.TextBox txtPersonNumber;
        private System.Windows.Forms.ComboBox cbBuses;
        private System.Windows.Forms.Button btnBusAnimated;
        private System.Windows.Forms.Label lblPersonNumber;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDailyRecord;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.ComboBox cBTrip;
    }
}