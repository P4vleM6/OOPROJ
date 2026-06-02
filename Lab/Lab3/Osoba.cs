using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJlab3
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public Osoba(string ime, string prezime, string telefon, DateTime datumRodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            DatumRodjenja = datumRodjenja;
        }

        public override string ToString()
        {
            return $"Ime: {Ime},  Prezime: {Prezime},  Telefon: {Telefon},  Datum: {DatumRodjenja:dd.MM.yyyy}";
        }

        public delegate int SortDelegate(Osoba o1, Osoba o2);

        public static int PorediPoImenu(Osoba o1, Osoba o2)
        {
            return o1.Ime.CompareTo(o2.Ime);
        }

        public static int PorediPoPrezimenu(Osoba o1, Osoba o2)
        {
            return o1.Prezime.CompareTo(o2.Prezime);
        }

        public static int PorediPoDatumu(Osoba o1, Osoba o2)
        {
            return o1.DatumRodjenja.CompareTo(o2.DatumRodjenja);
        }

        public static string FormatirajDatum(DateTime datum)
        {
            return datum.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}
