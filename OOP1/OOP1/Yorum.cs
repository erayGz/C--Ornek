using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Yorum
    {
        //Yorum adında yeni bir class oluşturun
        //Yazan kişinin adı soyadı, yorumun yazılma tarihi tutulsun
        //GöreceliZaman adında bir değişken yazılma tarihine göre
        //"1 dk önce", "Şimdi", "1 saat önce" gibi değer döndürsün.
        
            public string AdSoyad { get; set; }
            public DateTime YorumYazilmaTarihi { get; set; }

            public string GoreceliZaman
            {
                get
                {
                    TimeSpan sure = DateTime.Now - YorumYazilmaTarihi;

                    if (sure.TotalSeconds < 20)
                    {
                        return "Şimdi";
                    }
                    else if (sure.TotalSeconds < 60)
                    {
                        return sure.Seconds + " sn önce";
                    }
                    else if (sure.TotalMinutes < 60)
                    {
                        return sure.Minutes + " dk önce";
                    }

                    return sure.Days + " gün" + sure.Hours + " saat" + sure.Minutes + " dk önce";

                }



            }

            public Yorum()
            {
                YorumYazilmaTarihi = DateTime.Now;
            }
        }
}
