using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHRS.UI.Models
{
    public partial class FRMDoktorTanimlamaEkrani : Form
    {
        public static Bolum[] Bolumler { get; set; }
        public FRMDoktorTanimlamaEkrani()
        {
            InitializeComponent();
        }

        private void FRMDoktorTanimlamaEkrani_Load(object sender, EventArgs e)
        {
            if (Bolumler != null)
            {
                cmbBolum.DataSource = Bolumler;
                cmbBolum.DisplayMember = "BolumAdi";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            string telefon = mTxtTelefon.Text;
            object bolum = cmbBolum.SelectedItem;

            if (string.IsNullOrWhiteSpace(adSoyad) || telefon.Length < 14 || bolum == null)
            {
                MessageBox.Show("Tüm alanları doldurunuz ! ", "UYARI ", MessageBoxButtons.OK);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(adSoyad, @"^[a-zA-ZĞÜŞİÖÇığüşöç\s]+$"))
            {
                MessageBox.Show("Adı Soyadı alanını dodluruken sadece harf giriniz");
            }
            Doktor doktor = new Doktor
            {
                AdSoyad = adSoyad,
                Bolum = (Bolum)bolum,
                Telefon = telefon
            };
            lstDokttorlar.Items.Add(doktor);
            Temizle();

            MessageBox.Show("Doktor başarıyla eklenmiştir","TEBRİKLER",MessageBoxButtons.OK);
        }
        public void Temizle()
        {
            txtAdSoyad.Text = mTxtTelefon.Text = string.Empty;
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Doktor[] doktarlar = new Doktor[0];

            foreach (Doktor item in lstDokttorlar.Items)
            {
                Array.Resize(ref doktarlar, doktarlar.Length + 1);//boyutunu değiştirdik
                doktarlar[doktarlar.Length - 1] = item;//elemanı istediğimiz indeksine atadık
                                                       //array ile aldığımız itemleri yeni listemize aktaracağız. 
                                                       //array resize arrayın boyutunu arttırmamızı sağlıyor. listedeki itemleri donduğumuzde kaç tane doktor varsa içinde döner. amacımız yeni bir array oluşturduk bu diziyi referans alarak yani referansını değiştirmeden yeni bir boyut katmak her bir döndüğünde yani +1 bir katarak alıyoruz 
                                                       //doktorların lengtini de indexten kaynaklı index 0 dan başladığı icin -1 azaltarak yazdık.

            }

            FRMRandevuOlusturmaEkrani form3 = new FRMRandevuOlusturmaEkrani(doktarlar);
            form3.Show();

        }
    }
}
