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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void przeczytaneBotton_Click(object sender, EventArgs e)
        {
            przeczytane tmp = new przeczytane();
            tmp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doprzeczytania tmp = new Doprzeczytania();
            tmp.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Dokupienia tmp = new Dokupienia();
            tmp.ShowDialog();
        }

    }
}
