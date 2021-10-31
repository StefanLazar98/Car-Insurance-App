using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaAsigurari
{
    public partial class MainForm : Form
    {
        private List<Asigurare> _asigurare;
        public MainForm()
        {
            InitializeComponent();
            _asigurare = new List<Asigurare>();
        }

        private void adaugareAsigurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asigurari form1 = new Asigurari(_asigurare);
            form1.ShowDialog();
            _asigurare = form1.asigurari;
        }

        private void vizualizareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vizualizare viz = new Vizualizare(_asigurare);
            viz.ShowDialog();
        }
    }
}
