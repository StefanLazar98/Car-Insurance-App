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
    public partial class UserControl1 : UserControl
    {
        private Chart[] _chart;

        public Chart[] chart
        {
            get
            {
                return _chart;
            }
            set 
            {
                _chart = value;
            }
        }
        public UserControl1()
        {
            InitializeComponent();

            ResizeRedraw = true;
            chart = new[]
            {
                new Chart("RCA","red", 40),
                new Chart("CASCO","blue", 10),
                new Chart("Asigurare de bunuri","green", 25),
                new Chart("Asigurare de calatorie","orange", 18),
                new Chart("Asigurare de viata","purple", 7),
            };
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = e.ClipRectangle;

            var scala = r.Height / chart.Max(v => v.valoare);
            var latime = (r.Width - 200) / chart.Length;
            var maxInaltime = r.Height * 0.9;

            for(int i = 0; i < chart.Length; i++)
            {
                var inaltime = chart[i].valoare * scala;
                g.FillRectangle(new SolidBrush(Color.FromName(chart[i].coloana)), i * latime, r.Height - inaltime, (float)(latime * 0.8), inaltime);

            }

            var x = r.Width - 200;
            var y = 0;

            for(int i = 0; i < chart.Length; i++)
            {
                g.FillRectangle(new SolidBrush(Color.FromName(chart[i].coloana)), x, y, 35, 35);
                g.DrawString(chart[i].nume + " : " + chart[i].valoare, Font, new SolidBrush(Color.FromName(chart[i].coloana)), x + 35, y + 15);

                y += 35;
            }
        }
    }
}
