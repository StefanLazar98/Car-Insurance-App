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
    public partial class EditAsigurari : Form
    {
        private Asigurare _asigurare;
        public EditAsigurari(Asigurare asigurare)
        {
            InitializeComponent();
            _asigurare = asigurare;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string tip1 = cbTipAsigEdit.Text;
            string tip2 = cbAnEdit.Text;
            _asigurare.numeAsigurare = tip1;
            _asigurare.aniAsigurare = tip2;
            textBox1.Text = _asigurare.calculeazaPretAsigurareDupaNume().ToString();
            textBox2.Text = _asigurare.calculeazaPretTotalAsigurare().ToString();

        }

        private void EditForm1_Load(object sender, EventArgs e)
        {
            cbTipAsigEdit.Text = _asigurare.numeAsigurare.ToString();
            cbAnEdit.Text = _asigurare.aniAsigurare.ToString();
        }
    }
}
