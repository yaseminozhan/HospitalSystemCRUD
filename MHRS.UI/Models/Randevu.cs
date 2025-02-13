using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.UI.Models
{
    public class Randevu
    {
        public Hasta Hasta { get; set; }
        public DateTime Tarih { get; set; }

        public override string ToString()
        {
            return Hasta +" "+Tarih.ToShortDateString();
        }
    }
}
