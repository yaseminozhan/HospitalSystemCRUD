using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.UI.Models
{
    public class Doktor
    {
        public string AdSoyad { get; set; }
        public Bolum Bolum { get; set; }    
        public string Telefon { get; set; }

        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
