using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Vozac
    {
        private string ime;
        private string prezime;
        private DateTime datumRodjenja;
        private DateTime vazenjeDozvoleOd;
        private DateTime vazenjeDozvoleDo;
        private string brojDozvole;
        private string mestoIzdavanjaDozvole;
        private string pol;

        private string pathDoSlike;
        private List<Kategorija> listaKategorija;
        private List<Zabrana> listaZabrana;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string BrojDozvole
        {
            get { return brojDozvole; }
            set { brojDozvole = value; }
        }

        public string DatumRodjenja
        {
            get { return datumRodjenja.ToString("dd.MM.yyyy."); }
            set { datumRodjenja = DateTime.Parse(value); }
        }

        public string VazenjeDozvoleOd
        {
            get { return vazenjeDozvoleOd.ToString("dd.MM.yyyy."); }
            set { vazenjeDozvoleOd = DateTime.Parse(value); }
        }

        public string VazenjeDozvoleDo
        {
            get { return vazenjeDozvoleDo.ToString("dd.MM.yyyy."); }
            set { vazenjeDozvoleDo = DateTime.Parse(value); }
        }

        public string MestoIzdavanjaDozvole
        {
            get { return mestoIzdavanjaDozvole; }
            set { mestoIzdavanjaDozvole = value; }
        }

        public string Pol
        {
            get { return pol; }
            set { pol = value; }
        }

        public string PathDoSlike
        {
            get { return pathDoSlike; }
            set { pathDoSlike = value; }
        }

        public List<Kategorija> ListaKategorija
        {
            get { return listaKategorija; }
            set { listaKategorija = value; }
        }

        public List<Zabrana> ListaZabrana
        {
            get { return listaZabrana; }
            set { listaZabrana = value; }
        }

        public Vozac()
        {
            ime = string.Empty;
            prezime = string.Empty;
            datumRodjenja = DateTime.Now;
            vazenjeDozvoleOd = DateTime.Now;
            vazenjeDozvoleDo = DateTime.Now;
            brojDozvole = string.Empty;
            mestoIzdavanjaDozvole = string.Empty;
            pol = string.Empty;
            pathDoSlike = string.Empty;
            listaKategorija = new List<Kategorija>();
            listaZabrana = new List<Zabrana>();
        }

        public Vozac(string ime, string prezime, DateTime datumRodjenja, DateTime vazenjeDozvoleOd, DateTime vazenjeDozvoleDo, string brojDozvole, string mestoIzdavanjaDozvole, string pol, string pathDoSlike)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.vazenjeDozvoleOd = vazenjeDozvoleOd;
            this.vazenjeDozvoleDo = vazenjeDozvoleDo;
            this.brojDozvole = brojDozvole;
            this.mestoIzdavanjaDozvole = mestoIzdavanjaDozvole;
            this.pol = pol;
            this.pathDoSlike = pathDoSlike;
            this.listaKategorija = new List<Kategorija>();
            this.listaZabrana = new List<Zabrana>();
        }

        public Vozac(string ime, string prezime, DateTime datumRodjenja, DateTime vazenjeDozvoleOd, DateTime vazenjeDozvoleDo,
                    string brojDozvole, string mestoIzdavanjaDozvole, string pol, string pathDoSlike,
                    List<Kategorija> listaKategorija, List<Zabrana> listaZabrana)
            : this(ime, prezime, datumRodjenja, vazenjeDozvoleOd, vazenjeDozvoleDo, brojDozvole, mestoIzdavanjaDozvole, pol, pathDoSlike)
        {
            this.listaKategorija = listaKategorija;
            this.listaZabrana = listaZabrana;
        }

        public override bool Equals(object obj)
        {
            Vozac other = obj as Vozac;

            if (other == null)
                return false;

            return brojDozvole == other.brojDozvole;
        }
    }
}
