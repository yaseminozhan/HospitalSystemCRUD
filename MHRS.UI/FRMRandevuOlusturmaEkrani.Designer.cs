namespace MHRS.UI
{
    partial class FRMRandevuOlusturmaEkrani
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lstRandevular = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Telefonu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZRaporu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(163, 50);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(262, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // lstRandevular
            // 
            this.lstRandevular.FormattingEnabled = true;
            this.lstRandevular.Location = new System.Drawing.Point(101, 252);
            this.lstRandevular.Name = "lstRandevular";
            this.lstRandevular.Size = new System.Drawing.Size(332, 95);
            this.lstRandevular.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(359, 219);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "OLUŞTUR";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adı Soyadı";
            // 
            // Telefonu
            // 
            this.Telefonu.Location = new System.Drawing.Point(21, 80);
            this.Telefonu.Name = "Telefonu";
            this.Telefonu.Size = new System.Drawing.Size(68, 25);
            this.Telefonu.TabIndex = 4;
            this.Telefonu.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şikayet";
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(163, 84);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(262, 21);
            this.cmbDoktorlar.TabIndex = 1;
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(163, 137);
            this.txtSikayet.Multiline = true;
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(262, 77);
            this.txtSikayet.TabIndex = 0;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(163, 111);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(262, 20);
            this.dtpTarih.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarih";
            // 
            // btnZRaporu
            // 
            this.btnZRaporu.Location = new System.Drawing.Point(350, 12);
            this.btnZRaporu.Name = "btnZRaporu";
            this.btnZRaporu.Size = new System.Drawing.Size(75, 23);
            this.btnZRaporu.TabIndex = 6;
            this.btnZRaporu.Text = "Z RAPORU";
            this.btnZRaporu.UseVisualStyleBackColor = true;
            this.btnZRaporu.Click += new System.EventHandler(this.btnZRaporu_Click);
            // 
            // FRMRandevuOlusturmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.btnZRaporu);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Telefonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstRandevular);
            this.Controls.Add(this.cmbDoktorlar);
            this.Controls.Add(this.txtSikayet);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "FRMRandevuOlusturmaEkrani";
            this.Text = "FRMRandevuOlusturmaEkrani";
            this.Load += new System.EventHandler(this.FRMRandevuOlusturmaEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ListBox lstRandevular;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Telefonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZRaporu;
    }
}