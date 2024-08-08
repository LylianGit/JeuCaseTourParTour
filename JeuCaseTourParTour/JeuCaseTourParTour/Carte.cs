using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCaseTourParTour
{
    public class Carte
    {
        private int hauteurMin;
        private int hauteurMax;
        private int longueurMin;
        private int longueurMax;

        public Carte(int hauteurMin, int hauteurMax, int longueurMin, int longueurMax)
        {
            this.hauteurMin = hauteurMin;
            this.hauteurMax = hauteurMax;
            this.longueurMin = longueurMin;
            this.longueurMax = longueurMax;
        }

        public int getHauteurMin()
        {
            return hauteurMin;
        }

        public int getHauteurMax()
        {
            return hauteurMax;
        }

        public int getLongueurMin()
        {
            return longueurMin;
        }

        public int getLongueurMax()
        {
            return longueurMax;
        }
    }
}
