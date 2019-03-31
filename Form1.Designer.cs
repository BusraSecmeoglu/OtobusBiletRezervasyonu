namespace OtobusBiletRezervasyonu
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
            this.tbxBusName = new System.Windows.Forms.TextBox();
            this.tbxPlateNo = new System.Windows.Forms.TextBox();
            this.nudSeatCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listboxBuses = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBusName
            // 
            this.tbxBusName.Location = new System.Drawing.Point(35, 62);
            this.tbxBusName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBusName.Name = "tbxBusName";
            this.tbxBusName.Size = new System.Drawing.Size(132, 22);
            this.tbxBusName.TabIndex = 0;
            // 
            // tbxPlateNo
            // 
            this.tbxPlateNo.Location = new System.Drawing.Point(229, 62);
            this.tbxPlateNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPlateNo.Name = "tbxPlateNo";
            this.tbxPlateNo.Size = new System.Drawing.Size(132, 22);
            this.tbxPlateNo.TabIndex = 1;
            // 
            // nudSeatCount
            // 
            this.nudSeatCount.Location = new System.Drawing.Point(435, 62);
            this.nudSeatCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudSeatCount.Name = "nudSeatCount";
            this.nudSeatCount.Size = new System.Drawing.Size(160, 22);
            this.nudSeatCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Otobüs Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plaka No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Koltuk Sayısı";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(643, 58);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // listboxBuses
            // 
            this.listboxBuses.FormattingEnabled = true;
            this.listboxBuses.ItemHeight = 16;
            this.listboxBuses.Location = new System.Drawing.Point(35, 116);
            this.listboxBuses.Margin = new System.Windows.Forms.Padding(4);
            this.listboxBuses.Name = "listboxBuses";
            this.listboxBuses.Size = new System.Drawing.Size(560, 388);
            this.listboxBuses.TabIndex = 7;
            this.listboxBuses.SelectedIndexChanged += new System.EventHandler(this.ListboxBuses_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(751, 58);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(859, 58);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listboxBuses);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSeatCount);
            this.Controls.Add(this.tbxPlateNo);
            this.Controls.Add(this.tbxBusName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBusName;
        private System.Windows.Forms.TextBox tbxPlateNo;
        private System.Windows.Forms.NumericUpDown nudSeatCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listboxBuses;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

