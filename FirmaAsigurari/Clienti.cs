using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace FirmaAsigurari
{
    public partial class Clienti : Form
    {
        List<Client> clienti = new List<Client>();
        public Asigurare _asigurare;
        public Clienti()
        {
            InitializeComponent();
        }

        public Clienti(Asigurare asigurari)
        {
            InitializeComponent();
            _asigurare = asigurari;
        }

        public void AfiseazaClienti()
        {
            listView1.Items.Clear();
            foreach(Client c in clienti)
            {
                ListViewItem lvi = new ListViewItem(c.Nume);
                lvi.SubItems.Add(c.TipPlata);
                lvi.SubItems.Add(c.Telefon);
                lvi.Tag = c;
                listView1.Items.Add(lvi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    errorProvider1.SetError(textBox1, "Va rugam introduceti un nume!");
                }
                else
                    if (string.IsNullOrEmpty(textBox2.Text.Trim()))
                {
                    errorProvider1.SetError(textBox2, "Va rugam introduceti un numar de telefon!");
                }
                else
                    if(comboBox1.SelectedItem == null)
                {
                    errorProvider1.SetError(comboBox1, "Va rugam alegeti o modalitate de plata");
                }
                else
                {
                    string tip1 = textBox1.Text.Trim();
                    string tip2 = textBox2.Text.Trim();
                    string tip3 = comboBox1.SelectedItem.ToString();

                    var c = new Client(tip1,tip3,tip2);
                    clienti.Add(c);

                    string nume = _asigurare.numeAsigurare;
                    string ani = _asigurare.aniAsigurare;

                    _asigurare = new Asigurare(nume, ani, c);

                    AfiseazaClienti();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.Text = "";
                comboBox1.SelectedIndex = -1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alegeti un client!");
                return;
            }
            ListViewItem lvi = listView1.SelectedItems[0];
            Client c = (Client)lvi.Tag;

            EditClienti editForm2 = new EditClienti(c);
            if(editForm2.ShowDialog() == DialogResult.OK)
            {
                AfiseazaClienti();
            }
        }

        private void Label5_DragEnter(object sender, DragEventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            Client client = (Client)lvi.Tag;
            clienti.Remove(client);
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void ListView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Move);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, null);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBox1.Text.Length < 2)
            {
                errorProvider1.SetError(textBox1, "Nume prea scurt!");
                e.Cancel = true;
            }
            string nume = textBox1.Text.Trim();
            foreach (char c in nume)
            {
                if (c >= '0' && c <= '9')
                {
                    errorProvider1.SetError(textBox1, "Numele nu poate include cifre!");
                    e.Cancel = true;
                }
            }

        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, null);
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length != 10)
            {
                errorProvider1.SetError(textBox2, "Numarul de telefon are 10 cifre!");
                e.Cancel = true;
            }
            string telefon = textBox2.Text.Trim();
            foreach(char c in telefon)
            {
                if(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    errorProvider1.SetError(textBox2, "Telefonul nu poate contine decat cifre!");
                    e.Cancel = true;
                }
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
            using (FileStream stream = File.Create("RouteSerialized.xml"))
            {
                serializer.Serialize(stream, clienti);
            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
            using (FileStream stream = File.OpenRead("RouteSerialized.xml"))
            {
                clienti = (List<Client>)serializer.Deserialize(stream);
                AfiseazaClienti();
            }
        }
    }
}
