using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatandaşlık
{
    class insan
    {
        public string AdSoyad { get; set; }
        public bool CanliMi { get; set; }
        public insan()
        {
            CanliMi = true;
        }
        public insan(string adSoyad)
        {
            AdSoyad = adSoyad;
            CanliMi = true;
        }
        public static string SelamVer()
        {
            return "Selamlar";
        }
        public string AdiniSoyle()
        {
            return "Benim adım " + AdSoyad;
        }
    }
}
