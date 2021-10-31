using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAsigurari
{
    public class Chart
    {
        public string nume { get; set; }
        public string coloana { get; set; }
        public int valoare { get; set; }

        public Chart(string n, string c, int v)
        {
            nume = n;
            coloana = c;
            valoare = v;
        }
    }
}
