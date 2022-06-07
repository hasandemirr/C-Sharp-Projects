using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatandaşlık
{
    class TCVatandas
    {
        public long TCNo { get; set; }
        public string AdSoyad { get; set; }
        public DateTime Dogum { get; set; }
        public DateTime KayitTarihi { get; set; }

        public TCVatandas()
        {
            KayitTarihi = DateTime.Now;
        }
        public string VizeAl()
        {
            int yas = yashesapla(Dogum);
            if (yas >= 18)
            {
                return "Başvurabilirsiniz";
            }
            else
                return "Veli İzni Gerekli";
        }

        private int yashesapla(DateTime dogum)
        {
            return DateTime.Today.Year - dogum.Year;
        }
    }
}
