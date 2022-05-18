using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ABDVatandas
    {
        public string AdSoyad { get; set; }
        public DateTime Dogumtarihi { get; set; }
        public string Dil { get; set; }

        public int Yas
        {
            get
            {
                return DateTime.Today.Year - Dogumtarihi.Year;

            }
        }
    }
}
