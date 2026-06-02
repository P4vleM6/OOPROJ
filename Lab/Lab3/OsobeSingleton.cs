using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJlab3
{
    internal class OsobeSingleton
    {
        private static OsobeSingleton instance;
        public List<Osoba> Osobe { get; private set; }

        private OsobeSingleton()
        {
            Osobe = new List<Osoba>();
        }

        public static OsobeSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new OsobeSingleton();
                return instance;
            }
        }
    }
}
