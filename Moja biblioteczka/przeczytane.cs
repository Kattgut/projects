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
    public partial class przeczytane : Form
    {
        public przeczytane()
        {
            InitializeComponent();

        }
        Ksiazki k = new Ksiazki();
        public void clear()
        {
            txtNazwisko.Text = txtImie.Text = txtTytul.Text = txtOcena.Text = txtKomentarz.Text = " ";
        }
        
        delegate void DelegatZadania();
        private void pobierzDane()
        {
            if (przeczytaneGridView1.InvokeRequired)
            {
                DelegatZadania d = pobierzDane;
                this.Invoke(d);
            }
            else
            {
                var db = new BibliotekaEntities();
                var k = db.Ksiazki.Where(pr => pr.IDPolki == 1).Select(pr => new { IDKsiazki = pr.IDKsiazki, Nazwisko = pr.Nazwisko, Imie = pr.Imie, Tytul = pr.Tytul, ocena = pr.Ocena }).OrderBy(pr => pr.Nazwisko);
                przeczytaneGridView1.DataSource = k.ToList();
            }
        }
        private void przeczytane_Load(object sender, EventArgs e)
        {
            var t1 = new Task(() =>
            {
                pobierzDane();
            });
            t1.Start();
        }

        private void przeczytaneGridView1_DoubleClick(object sender, EventArgs e)
        {
            k.IDKsiazki = Convert.ToInt32(przeczytaneGridView1.CurrentRow.Cells["IDKsiazki"].Value);
            using (BibliotekaEntities db = new BibliotekaEntities())
            {
                k = db.Ksiazki.Where(p => p.IDKsiazki == k.IDKsiazki).FirstOrDefault();
                txtNazwisko.Text = k.Nazwisko;
                txtImie.Text = k.Imie;
                txtTytul.Text = k.Tytul;
                txtOcena.Text = k.Ocena.ToString();
                txtKomentarz.Text = k.Uwagi;
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć Ksiażkę z listy ?", "Usuwanie książki", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (k.IDKsiazki == 0)
                MessageBox.Show("Wybierz książkę, którą chcesz edytować");
            else
            {              
                k.Nazwisko = txtNazwisko.Text.Trim();
                k.Imie = txtImie.Text.Trim();
                k.Tytul = txtTytul.Text.Trim();
                k.Ocena = Convert.ToInt32(txtOcena.Text);
                k.Uwagi = txtKomentarz.Text.Trim();

                using (BibliotekaEntities db = new BibliotekaEntities())
                {
                    db.Entry(k).State = EntityState.Modified;
                    db.SaveChanges();
                }
                clear();
                MessageBox.Show("Zmiany zostały zapisane.");
                pobierzDane();
            }
        }
    }
}
