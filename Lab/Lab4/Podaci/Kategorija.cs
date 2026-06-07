using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Kategorija
    {
        private string oznakaKategorije;
        private DateTime datumOd;
        private DateTime datumDo;

        public string OznakaKategorije
        {
            get { return oznakaKategorije; }
            set { oznakaKategorije = value; }
        }

        public DateTime DatumOd
        {
            get { return datumOd; }
            set { datumOd = value; }
        }

        public DateTime DatumDo
        {
            get { return datumDo; }
            set { datumDo = value; }
        }

        public Kategorija()
        {
            oznakaKategorije = string.Empty;
            datumOd = DateTime.Now;
            datumDo = DateTime.Now;
        }

        public Kategorija(string oznakaKategorije, DateTime datumOd, DateTime datumDo)
        {
            this.oznakaKategorije = oznakaKategorije;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
        }
    }
}
