using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Defteri
{
    abstract class Hesap
    {
        public long HesapNo { get; set; }
        public int SubeKodu { get; set; }
        public string IBAN { get; set; }
        public decimal Bakiye { get; set; }

        public virtual string ParaCek(decimal tutar)
        {
            Bakiye -= tutar;
            return "Güncel bakiyeniz " + Bakiye;
        }
        public virtual string ParaYatir(decimal tutar)
        {
            Bakiye += tutar;
            return "Güncel bakiyeniz: " + Bakiye;
        }

    }
    class VadesizHesap:Hesap
    {
        public override string ParaCek(decimal tutar)
        {
            if(Bakiye<tutar)
            {
                return "Yetersiz Bakiye";
            }
            if(tutar%5==0)
            {
                return base.ParaCek(tutar);
            }
            else
            {
                return "Çekmek istediğiniz tutar 5'in katları olmalıdır.";
            }
        }
    }
    class VadeliHesap:Hesap
    {
        public DateTime VadeBasi { get; set; }
        public int VadeGunSayisi { get; set; }
        public DateTime VadeSonu 
        {
            get
            {
                return VadeBasi.AddDays(VadeGunSayisi);
            }
        }
        public override string ParaCek(decimal tutar)
        {
            if (DateTime.Today.Date != VadeSonu.Date)
                return "Vade sonunu bekleyiniz";
            else if (Bakiye < tutar)
                return "yetersiz bakiye";
            else if (tutar % 5 != 0)
                return "Çekmek istediğiniz tutar 5'in katları olmalıdır.";
            else
                return base.ParaCek(tutar);
        }
        public override string ParaYatir(decimal tutar)
        {
            if (DateTime.Today.Date==VadeSonu.Date)
            {
                return base.ParaYatir(tutar);
            }
            else
                return "Vade sonu Tarihini Bekleyiniz";
        }

    }
}
