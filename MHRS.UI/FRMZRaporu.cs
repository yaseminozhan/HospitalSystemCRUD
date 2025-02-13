using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MHRS.UI.Models;

namespace MHRS.UI
{
    public partial class FRMZRaporu : Form
    {
        private Randevu[] randevular;
        public FRMZRaporu(Randevu[] array) : this()
        {
            this.randevular = array;

        }
        public FRMZRaporu()
        {
            InitializeComponent();
        }

        private void FRMZRaporu_Load(object sender, EventArgs e)
        {
            lvZRaporu.View = View.Details;
            lvZRaporu.GridLines = true;
            lvZRaporu.Columns.Add("Hasta Adı Soyadı", 160);
            lvZRaporu.Columns.Add("Bölümü", 160);
            lvZRaporu.Columns.Add("Doktoru", 160);
            lvZRaporu.Columns.Add("Şikayeti", 160);
            lvZRaporu.Columns.Add("Tarih", 160);

            ListeyiGuncelle(DateTime.Today, DateTime.Today);

        }

        private void ListeyiGuncelle(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            lvZRaporu.Items.Clear();

            var filtrelenmisRandevular = randevular.Where(x => x.Tarih.Date >= baslangicTarihi && x.Tarih.Date <= bitisTarihi);

            foreach (var item in filtrelenmisRandevular)
            {
                ListViewItem listViewItem = new ListViewItem(item.Hasta.AdSoyad);
                listViewItem.SubItems.Add(item.Hasta.Doktor.Bolum.ToString());
                listViewItem.SubItems.Add(item.Hasta.Doktor.ToString());
                listViewItem.SubItems.Add(item.Hasta.Sikayet);
                listViewItem.SubItems.Add(item.Tarih.ToShortDateString());

                lvZRaporu.Items.Add(listViewItem);

            }
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslamaTarihi = dtpBaslangic.Value.Date;
                DateTime bitisTarihi = dtpBitis.Value.Date;

                ListeyiGuncelle(baslamaTarihi, bitisTarihi);

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.AddWorksheet("ZRaporu");

                    worksheet.Cell(1, 1).Value = "Hasta Adı Soyadı";
                    worksheet.Cell(1, 2).Value = "Bölüm";
                    worksheet.Cell(1, 3).Value = "Doktor";
                    worksheet.Cell(1, 4).Value = "Şikayet";
                    worksheet.Cell(1, 5).Value = "Tarih";

                    int row = 2;
                    foreach (ListViewItem item in lvZRaporu.Items)
                    {
                        worksheet.Cell(row, 1).Value = item.SubItems[0].Text;
                        worksheet.Cell(row, 2).Value = item.SubItems[1].Text;
                        worksheet.Cell(row, 3).Value = item.SubItems[2].Text;
                        worksheet.Cell(row, 4).Value = item.SubItems[3].Text;
                        worksheet.Cell(row, 5).Value = item.SubItems[4].Text;
                        row++;
                    }

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Excel Dosyasını Kaydet";
                        saveFileDialog.FileName = "ZRaporu.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);
                            MessageBox.Show("Excel Başarıyla oluşturuldu");
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata oluştu : {ex.Message}");
            }
        }
    }
}
