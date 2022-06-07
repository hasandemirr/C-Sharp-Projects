using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatandaşlık
{
    class Yorum
    {
        public string AdSoyad { get; set; }
        public DateTime GirişTarihi { get; set; }
        public String GoreceZaman 
        { 
            get
            {
                TimeSpan sure = DateTime.Now - GirişTarihi;
                if(sure.TotalSeconds<20)
                {
                    return "şimdi";
                }
                else if(sure.TotalSeconds<60 || sure.TotalSeconds >20)
                {
                    return sure.Seconds + " sn önce";
                }
                else if (sure.TotalMinutes < 60)
                {
                    return sure.Minutes + " dk önce";
                }
                return sure.Days + " gün önce";
            }
             
        }
        public Yorum()
        {
            GirişTarihi = DateTime.Now;
        }

    }
}
