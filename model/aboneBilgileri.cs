using ATMUygulamasi.enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi.model
{
    public class aboneBilgileri
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string bakiye { get; set; }
        public string ibanno { get; set; }
        public string kullanciAdi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public string emailAd { get; set; }
        public string GuvenlikSoru { get; set; }
        public string guvenlikCevabi { get; set; }
        public Loginstatus status { get; set; }

    }
}
