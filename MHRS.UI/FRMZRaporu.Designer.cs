namespace MHRS.UI
{
    partial class FRMZRaporu
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
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvZRaporu = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(67, 120);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangic.TabIndex = 1;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(556, 120);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 20);
            this.dtpBitis.TabIndex = 2;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(645, 395);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(111, 43);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Döküman Oluştur";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(288, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Z Raporu Ekranı";
            // 
            // lvZRaporu
            // 
            this.lvZRaporu.HideSelection = false;
            this.lvZRaporu.Location = new System.Drawing.Point(75, 185);
            this.lvZRaporu.Name = "lvZRaporu";
            this.lvZRaporu.Size = new System.Drawing.Size(681, 188);
            this.lvZRaporu.TabIndex = 5;
            this.lvZRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // FRMZRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvZRaporu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Name = "FRMZRaporu";
            this.Text = "FRMZRaporu";
            this.Load += new System.EventHandler(this.FRMZRaporu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvZRaporu;
    }
}