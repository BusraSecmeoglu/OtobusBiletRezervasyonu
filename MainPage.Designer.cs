namespace OtobusBiletRezervasyonu
{
    partial class MainPage
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
            this.bTicket = new System.Windows.Forms.Button();
            this.bControl = new System.Windows.Forms.Button();
            this.bVehicleControl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bTicket
            // 
            this.bTicket.Location = new System.Drawing.Point(48, 89);
            this.bTicket.Margin = new System.Windows.Forms.Padding(4);
            this.bTicket.Name = "bTicket";
            this.bTicket.Size = new System.Drawing.Size(100, 28);
            this.bTicket.TabIndex = 0;
            this.bTicket.Text = "Bilet Kes";
            this.bTicket.UseVisualStyleBackColor = true;
            this.bTicket.Click += new System.EventHandler(this.bTicket_Click);
            // 
            // bControl
            // 
            this.bControl.Location = new System.Drawing.Point(245, 89);
            this.bControl.Margin = new System.Windows.Forms.Padding(4);
            this.bControl.Name = "bControl";
            this.bControl.Size = new System.Drawing.Size(100, 28);
            this.bControl.TabIndex = 0;
            this.bControl.Text = "Kontrol";
            this.bControl.UseVisualStyleBackColor = true;
            this.bControl.Click += new System.EventHandler(this.bControl_Click);
            // 
            // bVehicleControl
            // 
            this.bVehicleControl.Location = new System.Drawing.Point(436, 89);
            this.bVehicleControl.Margin = new System.Windows.Forms.Padding(4);
            this.bVehicleControl.Name = "bVehicleControl";
            this.bVehicleControl.Size = new System.Drawing.Size(100, 28);
            this.bVehicleControl.TabIndex = 0;
            this.bVehicleControl.Text = "Araç Takip";
            this.bVehicleControl.UseVisualStyleBackColor = true;
            this.bVehicleControl.Click += new System.EventHandler(this.bVehicleControl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bTicket);
            this.groupBox1.Controls.Add(this.bVehicleControl);
            this.groupBox1.Controls.Add(this.bControl);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(615, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 235);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bTicket;
        private System.Windows.Forms.Button bControl;
        private System.Windows.Forms.Button bVehicleControl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}