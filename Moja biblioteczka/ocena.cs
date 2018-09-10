using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moja_biblioteczka
{
    public delegate void slabaKsiazkaHandler(string tytul);
    class ocena
    {
        Ksiazki k = new Ksiazki();
        public event slabaKsiazkaHandler slabaKsiazka;
        public void ocen(Ksiazki ksiazka)
        {
            if (ksiazka.Ocena < 3 || slabaKsiazka != null)
            {
                slabaKsiazka(k.Tytul);
            }

        }
    }
}
     
