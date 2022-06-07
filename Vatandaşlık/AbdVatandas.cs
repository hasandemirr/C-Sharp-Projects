using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatandaşlık
{
    class AbdVatandas
    {
        public string AdSoyad { get; set; }
        public DateTime Dogum { get; set; }
        public string Dil { get; set; }

        public int Yas
        {
            get
            {
                return DateTime.Today.Year-Dogum.Year;
            }
        }
    }
}
