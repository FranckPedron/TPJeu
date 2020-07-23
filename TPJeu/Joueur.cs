using System;
using System.Collections.Generic;
using System.Text;

namespace TPJeu
{
    class Joueur
    {

        public int PointsVie { get; set; }

        public bool EstVivant
        {
            get 
            {
                return EstVivant;
            }
            private set
            {
                if (PointsVie <= 0)
                    EstVivant = false;
            }
        }

        public Joueur()
        {
            PointsVie = 150;
        }


        public void Attaque(Monstre monstre)
        {

        }

        public void SubitDegats(int degatsSubits)
        {

        }
    }
}
