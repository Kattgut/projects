using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.Entity;

namespace Moja_biblioteczka
{
    public partial class Doprzeczytania : Form, IFunckje
    {
        Ksiazki k = new Ksiazki();
        ocena o = new ocena();
        public Doprzeczytania()
        {
            InitializeComponent();
            o.slabaKsiazka += niskaOcena;
        }
        
        public void clear()
        {
            txtIDKsiazki.Text = txtNazwisko.Text = txtImie.Text = txtTytul.Text = txtOcena.Text = " ";
        }
        public void pobierzDane()
        {
            var db = new BibliotekaEntities();
            var k = db.Ksiazki.Where(pr => pr.IDPolki == 2).Select(pr => new
            {
                IDKsiazki = pr.IDKsiazki,
                Nazwisko = pr.Nazwisko,
                Imie = pr.Imie,
                Tytul = pr.Tytul,
                polka = pr.IDPolki
            }).OrderBy(pr => pr.Nazwisko);
            DoPrzeczytaniaGridView1.DataSource = k.ToList();
        }
        public void niskaOcena(string nazwa)
        {
            MessageBox.Show("Sprzedaj ksiązkę " + nazwa);
            slabaKsiazka sk = new slabaKsiazka();
            sk.ShowDialog();
            
            
        }
        private void Doprzeczytania_Load(object sender, EventArgs e)
        {
            pobierzDane();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k.IDKsiazki = Convert.ToInt32(txtIDKsiazki.Text);
            k.Nazwisko = txtNazwisko.Text;
            k.Imie = txtImie.Text;
            k.Tytul = txtTytul.Text;
            k.IDPolki = 1;
            k.Ocena = Convert.ToInt32(txtOcena.Text);

            o.ocen(k);
            
       using (BibliotekaEntities db = new BibliotekaEntities())
            {
                db.Entry(k).State = EntityState.Modified;
                db.SaveChanges();
            }
            clear();
            MessageBox.Show("Książka została przeniesiona");
            pobierzDane();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (BibliotekaEntities db = new BibliotekaEntities())
            {
                var entry = db.Entry(k);
                if (entry.State == EntityState.Detached)
                    db.Ksiazki.Attach(k);
                db.Ksiazki.Remove(k);
                db.SaveChanges();
                clear();
                pobierzDane();
            }
        }

        private void DoPrzeczytaniaGridView1_DoubleClick(object sender, EventArgs e)
        {
            k.IDKsiazki = Convert.ToInt32(DoPrzeczytaniaGridView1.CurrentRow.Cells["IDKsiazki"].Value);
            using (BibliotekaEntities db = new BibliotekaEntities())
            {
                k = db.Ksiazki.Where(p => p.IDKsiazki == k.IDKsiazki).FirstOrDefault();
                txtIDKsiazki.Text = k.IDKsiazki.ToString();
                txtNazwisko.Text = k.Nazwisko;
                txtImie.Text = k.Imie;
                txtTytul.Text = k.Tytul;
            }
        }
    }
}
