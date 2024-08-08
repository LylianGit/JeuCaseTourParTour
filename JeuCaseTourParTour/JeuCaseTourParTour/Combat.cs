using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCaseTourParTour
{
    public class Combat
    {
        private Carte carte;
        private List<Personnage> allies;
        private List<Personnage> ennemis;

        public Combat(Carte carte, List<Personnage> allies, List<Personnage> ennemis)
        {
            this.carte = carte;
            this.allies = allies;
            this.ennemis = ennemis;
        }

        /*public void Deplacement(Personnage p, bool hauteur, bool avancer, int nbCase)
        {
            int newPos = -1;
            if (p.GetDeplacementRestant() >= nbCase)
            {
                if (hauteur == true)
                {
                    newPos = (avancer == true) ? (p.GetPositionHauteur() + nbCase) : (p.GetPositionHauteur() - nbCase);
                }
                else if (hauteur == false)
                {
                    newPos = (avancer == true) ? (p.GetPositionLongueur() + nbCase) : (p.GetPositionLongueur() - nbCase);
                }
            }

            if (newPos >= 0 && (hauteur == true && newPos <= carte.getHauteurMax()) || (hauteur == false && newPos <= carte.getLongueurMax()))
            {
                p.Deplacement(hauteur, newPos, nbCase);
            }
        }*/

        public void SeDeplacer(Personnage p, int newPosY, int newPosZ)
        {
            int nbCase = Math.Abs(newPosY - p.GetPositionHauteur()) + Math.Abs(newPosZ - p.GetPositionLongueur());
            if (nbCase <= p.GetDeplacementRestant()
                && newPosY >= carte.getHauteurMin() && newPosY <= carte.getHauteurMax()
                && newPosZ >= carte.getLongueurMin() && newPosZ <= carte.getLongueurMax())
            {
                p.SeDeplacer(newPosY, newPosZ, nbCase);
            }


        }

    }
}
