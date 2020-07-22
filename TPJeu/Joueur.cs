using System;
using System.Collections.Generic;
using System.Text;

namespace TPJeu
{
    class Joueur
    {
        int PointsVie { get; }
        bool EstVivant { get; }
        public Joueur(int pointsvie)
        {
            PointsVie = pointsvie;
        }

        public void Attaque(Monstre monstre)
        {

        }

        public void SubitDegats(int degatsSubits)
        {

        }
    }
}
