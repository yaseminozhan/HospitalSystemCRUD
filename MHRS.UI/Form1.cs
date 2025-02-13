using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHRS.UI.Models;

namespace MHRS.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string bolumAdi = txtBolumAdi.Text;
            string bolumAciklamasi = txtBolumAciklama.Text;

            if (string.IsNullOrWhiteSpace(bolumAdi) || string.IsNullOrWhiteSpace(bolumAciklamasi))
            {
                MessageBox.Show("Bölüm adı veya açıklaması boş bırakılamaz. ", "UYARI", MessageBoxButtons.OK);
                return;
            }
            try
            {
                Bolum bolum = new Bolum
                {
                    Adi = bolumAdi,
                    Aciklama = bolumAciklamasi
                };
                lstBolumler.Items.Add(bolum);
                MessageBox.Show("Bölüm başarıyla eklendi", "Tebrikler", MessageBoxButtons.OK);
                Temizler();
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message, "UYARI", MessageBoxButtons.OK);

            }
        }
        public void Temizler()
        {
            //txtBolumAdi.Clear();
            //txtBolumAciklama.Clear();

            //txtBolumAdi.Text="";

            txtBolumAciklama.Text = txtBolumAdi.Text = string.Empty;

        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Bolum[] bolumDizisi = new Bolum[lstBolumler.Items.Count];
            int i = 0;
            foreach (Bolum item in lstBolumler.Items)
            {
                bolumDizisi[i++] = item;
            }


            FRMDoktorTanimlamaEkrani.Bolumler = bolumDizisi;

            FRMDoktorTanimlamaEkrani fRMDoktorTanimlamaEkrani = new FRMDoktorTanimlamaEkrani();
            fRMDoktorTanimlamaEkrani.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bölüm  Tanımlama Ekrani";


        }
    }
}
