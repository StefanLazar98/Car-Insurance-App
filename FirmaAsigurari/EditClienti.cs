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
    public partial class EditClienti : Form
    {
        private Client _client;
        public EditClienti(Client client)
        {
            InitializeComponent();
            _client = client;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = tbNumeEdit.Text.Trim();
            string tipPlata = cbTipPlataEdit.Text;
            string telefon = tbTelefonEdit.Text.Trim();
            _client.Nume = nume;
            _client.TipPlata = tipPlata;
            _client.Telefon = telefon;
        }

        private void EditForm2_Load(object sender, EventArgs e)
        {
            tbNumeEdit.Text = _client.Nume.ToString();
            cbTipPlataEdit.Text = _client.TipPlata.ToString();
            tbTelefonEdit.Text = _client.Telefon.ToString();
        }

        private void tbTelefonEdit_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbTelefonEdit, null);
        }

        private void tbTelefonEdit_Validating(object sender, CancelEventArgs e)
        {

            if (tbTelefonEdit.Text.Length != 10)
            {
                errorProvider1.SetError(tbTelefonEdit, "Numarul de telefon are 10 cifre!");
                e.Cancel = true;
            }
            string telefon = tbTelefonEdit.Text.Trim();
            foreach (char c in telefon)
            {
                if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    errorProvider1.SetError(tbTelefonEdit, "Telefonul nu poate contine decat cifre!");
                    e.Cancel = true;
                }
            }
            
        }

        private void tbNumeEdit_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbNumeEdit, null);
        }

        private void tbNumeEdit_Validating(object sender, CancelEventArgs e)
        {
            if (tbNumeEdit.Text.Length < 2)
            {
                errorProvider1.SetError(tbNumeEdit, "Nume prea scurt!");
                e.Cancel = true;
            }
            string nume = tbNumeEdit.Text.Trim();
            foreach (char c in nume)
            {
                if (c >= '0' && c <= '9')
                {
                    errorProvider1.SetError(tbNumeEdit, "Numele nu poate include cifre!");
                    e.Cancel = true;
                }
            }
        }
    }
}
