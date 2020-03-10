using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianVjezbaKiO
{
    class Vozilo
    {
        private char vrsta;
        private int maxBrzina, brojKotaca;


        public Vozilo(char vrsta, int brojKotaca, int maxBrzina)
        {
            this.vrsta = vrsta;
            this.brojKotaca = brojKotaca;
            this.maxBrzina = maxBrzina;
        }
        public Vozilo()
        {

        }
        public int getVrsta()
        {
            return vrsta;

        }


    }
}

    
   
