namespace MHRS.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.txtBolumAciklama = new System.Windows.Forms.TextBox();
            this.lstBolumler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm Açıklması";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bölüm Tanımlama Ekranı";
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Location = new System.Drawing.Point(277, 64);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(269, 20);
            this.txtBolumAdi.TabIndex = 3;
            // 
            // txtBolumAciklama
            // 
            this.txtBolumAciklama.Location = new System.Drawing.Point(277, 121);
            this.txtBolumAciklama.Multiline = true;
            this.txtBolumAciklama.Name = "txtBolumAciklama";
            this.txtBolumAciklama.Size = new System.Drawing.Size(269, 90);
            this.txtBolumAciklama.TabIndex = 4;
            // 
            // lstBolumler
            // 
            this.lstBolumler.FormattingEnabled = true;
            this.lstBolumler.Location = new System.Drawing.Point(44, 268);
            this.lstBolumler.Name = "lstBolumler";
            this.lstBolumler.Size = new System.Drawing.Size(502, 95);
            this.lstBolumler.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(471, 217);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGec
            // 
            this.btnGec.Location = new System.Drawing.Point(44, 378);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(502, 23);
            this.btnGec.TabIndex = 7;
            this.btnGec.Text = ">>>>>>";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstBolumler);
            this.Controls.Add(this.txtBolumAciklama);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.TextBox txtBolumAciklama;
        private System.Windows.Forms.ListBox lstBolumler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGec;
    }
}

