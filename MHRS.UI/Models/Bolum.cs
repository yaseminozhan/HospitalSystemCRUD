using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.UI.Models
{
    public class Bolum
    {
        private string _adi;
        public string Adi
        {
            //  get { return _adi; }
            get => _adi;
            set
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[a-zA-ZĞÜŞİÖÇığüşöç\s]+$"))
                {
                    throw new ArgumentException("Bölüm adını girerken sadece harf kullanınnız !! ");   
                }
                _adi = value;
            }
        }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return Adi;
        }
    }
}
