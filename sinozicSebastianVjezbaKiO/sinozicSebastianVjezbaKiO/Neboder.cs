using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianVjezbaKiO
{
    class Neboder
    {
        private int visina, brojKatova;

        public Neboder (int visina, int brojKatova)
        {
            this.visina = visina;
            this.brojKatova = brojKatova;
        }

        public Neboder()
        {

        }
        public int getVisina()
        {
            return visina;

        }
        public void setVisina(int visina)
        {
            this.visina = visina;
        }
        public int getBrojKatova()
        {
            return brojKatova;
        }
        public void setBrojKatova()
        {
            this.brojKatova = brojKatova;
        }
        public override string ToString()
        {
            return base.ToString();

        }
    }
    
}
