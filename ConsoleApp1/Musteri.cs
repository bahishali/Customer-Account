using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Musteri
    {
        public string Ad; //gerçek olan String, string: alias
        public string Soyad;
        public int MusteriNo;
        public decimal Bakiye;
        public decimal IndirimYap(decimal indirim)
        {
            return Bakiye - indirim;

        }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }

    }

