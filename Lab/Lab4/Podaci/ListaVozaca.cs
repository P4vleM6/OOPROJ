using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaVozaca
    {
        private static ListaVozaca instance = null;
        private List<Vozac> listaVozaca;
        public delegate void SortDelegate(List<Vozac> v);

        public static ListaVozaca Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaVozaca();
                }
                return instance;
            }
        }

        public List<Vozac> ListaVozacaVrednosti
        {
            get { return listaVozaca; }
        }

        public SortDelegate SortListDelegate
        {
            get; set;
        }

        private ListaVozaca()
        {
            listaVozaca = new List<Vozac>();
        }

        public bool DodajVozaca(Vozac vozac)
        {
            if (listaVozaca.Any(v => v.Equals(vozac)))
            {
                return false;
            }

            listaVozaca.Add(vozac);
            return true;
        }

        public Vozac GetVozac(string brojDozvole)
        {
            foreach (var v in listaVozaca)
            {
                if (v.BrojDozvole == brojDozvole)
                {
                    return v;
                }
            }
            return null;
        }

        public bool IzmeniVozaca(Vozac v)
        {
            Vozac pr = GetVozac(v.BrojDozvole);

            if (pr != null) 
                return false;

            pr.Ime = v.Ime;
            pr.Prezime = v.Prezime;
            pr.DatumRodjenja = v.DatumRodjenja;
            pr.VazenjeDozvoleOd = v.VazenjeDozvoleOd;
            pr.VazenjeDozvoleDo = v.VazenjeDozvoleDo;
            pr.BrojDozvole = v.BrojDozvole;
            pr.MestoIzdavanjaDozvole = v.MestoIzdavanjaDozvole;
            pr.Pol = v.Pol;
            pr.PathDoSlike = v.PathDoSlike;
            pr.ListaKategorija = v.ListaKategorija;
            pr.ListaZabrana = v.ListaZabrana;

            return true;
        }

        public bool ObrisiVozaca(Vozac v)
        {
            if (!listaVozaca.Contains(v))
                return false;

            listaVozaca.Remove(v);
            return true;
        }

        public void SortirajListu()
        {
            if (SortListDelegate != null)
                SortListDelegate.Invoke(listaVozaca);
        }
    }
}
