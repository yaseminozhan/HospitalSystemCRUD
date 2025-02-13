namespace MHRS.UI.Models
{
    partial class FRMDoktorTanimlamaEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstDokttorlar = new System.Windows.Forms.ListBox();
            this.btnGec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(129, 61);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(205, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefonu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bölümü";
            // 
            // mTxtTelefon
            // 
            this.mTxtTelefon.Location = new System.Drawing.Point(129, 104);
            this.mTxtTelefon.Mask = "(999) 000-0000";
            this.mTxtTelefon.Name = "mTxtTelefon";
            this.mTxtTelefon.Size = new System.Drawing.Size(205, 20);
            this.mTxtTelefon.TabIndex = 4;
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(129, 141);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(205, 21);
            this.cmbBolum.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(259, 177);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstDokttorlar
            // 
            this.lstDokttorlar.FormattingEnabled = true;
            this.lstDokttorlar.Location = new System.Drawing.Point(54, 253);
            this.lstDokttorlar.Name = "lstDokttorlar";
            this.lstDokttorlar.Size = new System.Drawing.Size(308, 95);
            this.lstDokttorlar.TabIndex = 7;
            // 
            // btnGec
            // 
            this.btnGec.Location = new System.Drawing.Point(54, 375);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(308, 23);
            this.btnGec.TabIndex = 8;
            this.btnGec.Text = ">>>>>>>>>>>>";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Doktor Tanımlama Ekranı";
            // 
            // FRMDoktorTanimlamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.lstDokttorlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.mTxtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "FRMDoktorTanimlamaEkrani";
            this.Text = "FRMDoktorTanimlamaEkrani";
            this.Load += new System.EventHandler(this.FRMDoktorTanimlamaEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mTxtTelefon;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstDokttorlar;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Label label4;
    }
}