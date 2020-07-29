using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TPJeu
{
    class BossDeFin
    {
        public bool EstVivant { get { return PtsDeVie > 0; } }
        public int PtsDeVie { get; private set; }
        private De de;

        public BossDeFin(int pts)
        {
            PtsDeVie = pts;
        }

        public void Attaque (Joueur joueur)
        {
            int ptsDegats = LanceLeDe(26);
            joueur.SubitDegats(ptsDegats);
        }
        
        public void SubitDegats (int degats)
        {
            PtsDeVie -= degats;
        }

        public int LanceLeDe(int val)
        {
            de = new De();
            return de.LanceLeDe(val);
        }
    }
}
