using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAsigurari
{
    public class Asigurare :ICloneable, IComparable
    {
        private string NumeAsigurare;
        private string AniAsigurare;
        public Client client;

        public Asigurare()
        {
            NumeAsigurare = " ";
            AniAsigurare = " ";
        }

        public Asigurare(string nume, string ani)
        {
            this.NumeAsigurare = nume;
            this.AniAsigurare = ani;
        }

        public Asigurare(string nume, string ani, Client c)
        {
            this.NumeAsigurare = nume;
            this.AniAsigurare = ani;
            this.client = c;
        }

        public string numeAsigurare
        {
            get { return NumeAsigurare; }
            set
            {
                if (value != null)
                    NumeAsigurare = value;
            }
        }

        public string aniAsigurare
        {
            get { return AniAsigurare; }
            set
            {
                if (value != null)
                    AniAsigurare = value;
            }
        }

        public int calculeazaPretAsigurareDupaNume()
        {
            int pret = 0;
                if (this.NumeAsigurare == "RCA")
                {
                    pret = 200;
                }
                else
                    if (this.NumeAsigurare == "CASCO")
                {
                    pret = 2000;
                }
                else
                    if (this.NumeAsigurare == "Asigurare de bunuri")
                {
                    pret = 10000;
                }
                else
                    if (this.NumeAsigurare == "Asigurare de calatorie")
                {
                    pret = 1500;
                }
                else
                    if (this.NumeAsigurare == "Asigurare de viata")
                {
                    pret = 15000;
                }
            return pret;
        }
            
   

        public object Clone()
        {
            Asigurare clona = (Asigurare)this.MemberwiseClone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            Asigurare a = (Asigurare)obj;
            if (this.calculeazaPretAsigurareDupaNume() > a.calculeazaPretAsigurareDupaNume())
                return 1;
            else
                if (this.calculeazaPretAsigurareDupaNume() < a.calculeazaPretAsigurareDupaNume())
                return -1;
            else
                return 0;
        }

        public int calculeazaPretTotalAsigurare()
        {
            int pret = 0;
            int result = Int32.Parse(aniAsigurare);
            for (int i=0; i < result; i++)
            {
                pret += this.calculeazaPretAsigurareDupaNume();
            }
            
            return pret;
        }

        public string toString()
        {
            string rezultat = this.numeAsigurare + "pe durata de " + this.AniAsigurare + " ani cu pretul de: " + this.calculeazaPretTotalAsigurare();
            return rezultat;
        }

        public static implicit operator List<object>(Asigurare v)
        {
            throw new NotImplementedException();
        }
    }
}
