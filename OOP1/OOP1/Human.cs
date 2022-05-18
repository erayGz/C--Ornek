using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Human
    {
        public string AdSoyad { get; set; }
        public bool CanliMi { get; set; }
        public Human()
        {
            CanliMi = true;
        }
        public Human(string adSoyad)
        {
            AdSoyad = adSoyad;
            CanliMi = true;
        }
        public static string SelamVer()
        {
            return "Merhaba";
        }
        public string AdiniSoyle()
        {
            return "Benim Adım " + AdSoyad;
        }
        
    }
}
