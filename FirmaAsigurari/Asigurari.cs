using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace FirmaAsigurari
{
    public partial class Asigurari : Form
    {
       public List<Asigurare> asigurari;
        public Asigurari(List<Asigurare> a)
        {
            InitializeComponent();
            this.asigurari = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (cbTipAsig.SelectedItem == null)
                {
                    errorProvider1.SetError(cbTipAsig, "Va rugam introduceti un tip de asigurare!");
                }
                else
                    if (cbAn.SelectedItem == null)
                {
                    errorProvider1.SetError(cbAn, "Va rugam introduceti anii de asigurare!");
                }
                else
                {
                    
                    string tip1 = cbTipAsig.SelectedItem.ToString();
                    string tip2 = cbAn.SelectedItem.ToString();
                    var a = new Asigurare(tip1, tip2);
                    asigurari.Add(a);
                    tbPret.Text = a.calculeazaPretAsigurareDupaNume().ToString();
                    AfisareAsigurari();
                    tbPretTotal.Text = a.calculeazaPretTotalAsigurare().ToString();

                    Clienti form2 = new Clienti(a);
                    form2.ShowDialog();

                    asigurari.Remove(a);
                    a = form2._asigurare;
                    asigurari.Add(a);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cbTipAsig.Text = "";
                cbTipAsig.SelectedIndex = -1;
                cbAn.Text = "";
                cbAn.SelectedIndex = -1;
                tbPret.Clear();
                tbPretTotal.Clear();
            }
        }

        public void AfisareAsigurari()
        {
            listView1.Items.Clear();
            foreach(Asigurare a in asigurari)
            {
                ListViewItem lvi = new ListViewItem(a.numeAsigurare);
                int pret = a.calculeazaPretAsigurareDupaNume();
                int pretTotal = a.calculeazaPretTotalAsigurare();
                lvi.SubItems.Add(pret.ToString());
                lvi.SubItems.Add(a.aniAsigurare);
                lvi.SubItems.Add(pretTotal.ToString());
                lvi.Tag = a;
                listView1.Items.Add(lvi);
            }
        }


        private void Label5_DragEnter(object sender, DragEventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            Asigurare asigurare = (Asigurare)lvi.Tag;
            asigurari.Remove(asigurare);
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void ListView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Move);
        }

        private void serializareAltSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Asigurare>));
            using (FileStream s = File.Create("AsigurariSerializate.xml"))
            {
                serializer.Serialize(s, asigurari);
            }
        }

        private void deserializareALTDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Asigurare>));
            using (FileStream s = File.OpenRead("AsigurariSerializate.xml"))
            {
                asigurari = (List<Asigurare>)serializer.Deserialize(s);
                AfisareAsigurari();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza o asigurare");
                return;
            }
            ListViewItem lvi = listView1.SelectedItems[0];
            Asigurare asigurari = (Asigurare)lvi.Tag;

            EditAsigurari editForm1 = new EditAsigurari(asigurari);
            if(editForm1.ShowDialog() == DialogResult.OK)
            {
                AfisareAsigurari();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareAsigurari();
        }
    }
}
