using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAsigurari
{
    public class Client
    {
        private string nume;
        private string tipPlata;
        private string telefon;
        

        public Client()
        {
            this.nume = " ";
            this.tipPlata = " ";
            this.telefon = "";
        }

        public Client(string n, string tp, string t)
        {
            this.nume = n;
            this.tipPlata = tp;
            this.telefon = t;
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null)
                    nume = value;
            }
        }

        public string TipPlata
        {
            get { return tipPlata; }
            set
            {
                if (value != null)
                    tipPlata = value;
            }
        }

        public string Telefon
        {
            get { return telefon; }
            set
            {
                if (value != null)
                    telefon = value;
            }
        }
    }
}
