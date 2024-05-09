using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi.model
{
    public class LoginTable
    {
        public int id { get; set; }
        public string kullanciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public string emailad { get; set; }
        public string guvenliksoru { get; set; }
        public string guvenlikcevabi { get; set; }
    }
}
