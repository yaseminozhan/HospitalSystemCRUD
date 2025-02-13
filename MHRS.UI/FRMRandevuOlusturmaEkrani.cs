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
    public partial class FRMRandevuOlusturmaEkrani : Form
    {
        public FRMRandevuOlusturmaEkrani(Doktor[] array) : this()
        {
            foreach (Doktor item in array)
            {
                cmbDoktorlar.Items.Add(item);
            }
        }
        public FRMRandevuOlusturmaEkrani()
        {
            InitializeComponent();

        }

        private void FRMRandevuOlusturmaEkrani_Load(object sender, EventArgs e)
        {
            this.Text = "Randevu oluşturma Ekranı";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || cmbDoktorlar == null || string.IsNullOrWhiteSpace(txtSikayet.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz !!");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtAdSoyad.Text, @"^[a-zA-ZĞÜŞİÖÇığüşöç\s]+$"))
            {
                MessageBox.Show("Hasta adını gierken sadec harf kullanınız");
                return;
            }

            if (dtpTarih.Value < DateTime.Today)
            {
                MessageBox.Show("Geçmiş tarihe randevu oluşturulamaz !!");
                return;
            }

            Hasta hasta = new Hasta
            {
                AdSoyad = txtAdSoyad.Text,
                Doktor = (Doktor)cmbDoktorlar.SelectedItem,
                Sikayet = txtSikayet.Text
            };

            Randevu randevu = new Randevu
            {
                Hasta = hasta,  
                Tarih = dtpTarih.Value.Date
            };

            lstRandevular.Items.Add(randevu);

            Temizle();
            MessageBox.Show("Randevu başarıyla oluşturuldu.");
        }

        private void Temizle()
        {
            txtAdSoyad.Text = txtSikayet.Text = string.Empty;
            dtpTarih.Value = DateTime.Today;
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            Randevu[] randevular = new Randevu[lstRandevular.Items.Count];
            lstRandevular.Items.CopyTo(randevular, 0);

            FRMZRaporu form4 = new FRMZRaporu(randevular);
            form4.Show();
        }
    }
}
