using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCaseTourParTour
{
    public class Personnage
    {
        //private string nom;
        private int positionHauteur;
        private int positionLongueur;
        private int maxDeplacement;
        private int deplacementRestant;
        private int actionRestante;
        private int pv;
        private int dmg;
        private int portee;

        public void SetDmg(int dmg)
        {
            this.pv -= dmg;
        }

        public Personnage(int positionHauteur, int positionLongueur, int maxDeplacement, int pv, int dmg, int portee)
        {
            this.positionHauteur = positionHauteur;
            this.positionLongueur = positionLongueur;
            this.maxDeplacement = maxDeplacement;
            this.deplacementRestant = maxDeplacement;
            this.actionRestante = 1;
            this.pv = pv;
            this.dmg = dmg;
            this.portee = portee;
        }

        public int GetPositionHauteur() { return positionHauteur; }
        public int GetPositionLongueur() { return positionLongueur; }
        public int GetMaxDeplacement() { return maxDeplacement; }
        public int GetDeplacementRestant() { return deplacementRestant; }

        public string getPos()
        {
            return "y:" + positionHauteur + " " + "z:" + positionLongueur;
        }

        //Si hauteur = false alors longueur, si avancer = false alors reculer
        /*public void Deplacement(bool hauteur, int newPos, int nbCase)
        {
            if (hauteur == true)
            {
                positionHauteur = newPos;
            }
            else if (hauteur == false)
            {
                positionLongueur = newPos;
            }
            deplacementRestant -= nbCase;   
        }*/

        public void SeDeplacer(int newPosY, int newPosZ, int nbCase)
        {
            positionHauteur = newPosY;
            positionLongueur = newPosZ;
            deplacementRestant -= nbCase;
        }

        public void Attaquer(Personnage cible)
        {
            if(portee <= Math.Abs(positionHauteur - cible.GetPositionHauteur()) + Math.Abs(positionLongueur - cible.GetPositionLongueur()))
            {
                cible.SetDmg(dmg);
                this.actionRestante = 0;
            }           
        }

        public void FinDeTour()
        {
            deplacementRestant = maxDeplacement;
            this.actionRestante = 1;
        }
    }
}
