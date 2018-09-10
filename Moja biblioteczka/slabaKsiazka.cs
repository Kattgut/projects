using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moja_biblioteczka
{
    public partial class slabaKsiazka : Form
    {
        Image obraz;
        public slabaKsiazka()
        {
            InitializeComponent();
            obraz = Bitmap.FromFile("Images\\ksiazka.png");
            //C:\\Users\\KASIA\\Desktop\\Moja biblioteczka\\Moja biblioteczka\
            var t1 = new Task(() =>
            {
                rysuj(e);
            });
        }
        float dx = 0.05f;
        private PaintEventArgs e;

        public void rysuj(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            var m = g.Transform;                                             
            
            g.TranslateTransform(dx, 0);
            g.FillRectangle(Brushes.Black, 0, 0, 20, 500);
            g.DrawImage(obraz, 10, 10);
            g.ResetTransform();
            e.Graphics.DrawString("Ksiązka nie jest warta miejsca na półce!", SystemFonts.MenuFont, Brushes.Red, 20, 20);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rysuj(e);
                     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dx +=1.5f;
            
            this.Refresh();
        }
    }
}
