using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaAsigurari
{
    public partial class Vizualizare : Form
    {
        private List<Asigurare> _asigurare;

        public Vizualizare(List<Asigurare> asigurare)
        {
            InitializeComponent();
            _asigurare = asigurare;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Asigurare a in _asigurare)
            {
                ListViewItem lvi = new ListViewItem(a.numeAsigurare);
                int pret = a.calculeazaPretAsigurareDupaNume();
                int pretTotal = a.calculeazaPretTotalAsigurare();
                lvi.SubItems.Add(pret.ToString());
                lvi.SubItems.Add(a.aniAsigurare);
                lvi.SubItems.Add(pretTotal.ToString());
                lvi.SubItems.Add(a.client.Nume.ToString());
                lvi.SubItems.Add(a.client.TipPlata.ToString());
                lvi.SubItems.Add(a.client.Telefon.ToString());
                lvi.Tag = a;
                listView1.Items.Add(lvi);
            }
        }

        private void exportAsTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fisier Text | *.txt";
            saveFileDialog.Title = "Salveaza ca fisier text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.WriteLine("Tip Asigurare, Pret, Ani, Pret Total, Nume, Tip de Plata, Telefon");
                    foreach (Asigurare a in _asigurare)
                    {
                        int pret = a.calculeazaPretAsigurareDupaNume();
                        int pretTotal = a.calculeazaPretTotalAsigurare();
                        streamWriter.WriteLine($"{a.numeAsigurare}, {pret}, {a.aniAsigurare}, {pretTotal}, " + $"{a.client.Nume}, {a.client.TipPlata}, {a.client.Telefon}");

                    }
                    MessageBox.Show("Datele au fost exportate cu succes!");
                }

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
