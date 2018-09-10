using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moja_biblioteczka
{
    public partial class Dokupienia : Form, IFunckje
    {
        Ksiazki nowa = new Ksiazki();
        public Dokupienia()
        {
            InitializeComponent();
        }

        public void PobierzDane()
        {
            var db = new BibliotekaEntities();
            var k = db.Ksiazki.Where(pr => pr.IDPolki == 3).Select(pr => new
            {
                IDKsiazki = pr.IDKsiazki,
                Nazwisko = pr.Nazwisko,
                Imie = pr.Imie,
                Tytul = pr.Tytul,
                polka = pr.IDPolki
            }).OrderBy(pr => pr.Nazwisko);
            dgvDoKupienia.DataSource = k.ToList();
        }
        public void clear()
        {
            txtID.Text = txtNazwisko1.Text = txtImie1.Text = txtTytul.Text = " ";
            nowa.IDKsiazki = 0;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            nowa.IDKsiazki = Convert.ToInt32(txtID.Text);
            nowa.Nazwisko = txtImie1.Text.Trim();
            nowa.Imie = txtNazwisko1.Text.Trim();
            nowa.Tytul = txtTytul.Text.Trim();
            nowa.IDPolki = 3;

            using (BibliotekaEntities db = new BibliotekaEntities())
            {
                db.Ksiazki.Add(nowa);
                db.SaveChanges();
            }
            clear();
        }

        private void Dokupienia_Load(object sender, EventArgs e)
        {
            PobierzDane();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć Ksiażkę z listy ?", "Usuwanie książki", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (BibliotekaEntities db = new BibliotekaEntities())
                {
                    var entry = db.Entry(nowa);
                    if (entry.State == EntityState.Detached)
                        db.Ksiazki.Attach(nowa);
                    db.Ksiazki.Remove(nowa);
                    db.SaveChanges();
                    clear();
                    PobierzDane();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nowa.IDKsiazki = Convert.ToInt32(txtID.Text);
            nowa.Nazwisko = txtNazwisko1.Text;
            nowa.Imie = txtImie1.Text;
            nowa.Tytul = txtTytul.Text;
            nowa.IDPolki = 2;

            using (BibliotekaEntities db = new BibliotekaEntities())
            {
                db.Entry(nowa).State = EntityState.Modified;
                db.SaveChanges();
            }
            clear();
            MessageBox.Show("Książka została przeniesiona");
            PobierzDane();
        }

        private void dgvDoKupienia_DoubleClick(object sender, EventArgs e)
        {
            nowa.IDKsiazki = Convert.ToInt32(dgvDoKupienia.CurrentRow.Cells["IDKsiazki"].Value);
            using (BibliotekaEntities db = new BibliotekaEntities())
            {
                nowa = db.Ksiazki.Where(p => p.IDKsiazki == nowa.IDKsiazki).FirstOrDefault();
                txtID.Text = nowa.IDKsiazki.ToString();
                txtNazwisko1.Text = nowa.Nazwisko;
                txtImie1.Text = nowa.Imie;
                txtTytul.Text = nowa.Tytul;
            }
        }
    }
}
