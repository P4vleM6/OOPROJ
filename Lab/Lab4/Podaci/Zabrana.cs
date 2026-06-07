using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Zabrana
    {
        private string kategorija;
        private DateTime datumOd;
        private DateTime datumDo;

        public string Kategorija
        {
            get { return kategorija; }
            set { kategorija = value; }
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

        public Zabrana()
        {
            kategorija = string.Empty;
            datumOd = DateTime.Now;
            datumDo = DateTime.Now;
        }

        public Zabrana(string kategorija, DateTime datumOd, DateTime datumDo)
        {
            this.kategorija = kategorija;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
        }
    }
}
