using System;
using System.Collections.Generic;
using System.Text;

namespace TPJeu
{
    class MonstreFacile
    {
        public int degats=10;
        protected De de;        
        public bool EstVivant {get; private set;}

        public MonstreFacile()
        {
            de = new De();
            EstVivant=true;
        }

        public virtual void Attaque(Joueur joueur)
        {
            int lanceMonstre=LanceLeDe();
            int lanceJoueur=LanceLeDe();

            if(lanceMonstre>lanceJoueur)
                joueur.SubitDegats(degats);
        }

        public void SubitDegats()
        {
            EstVivant=false;
        }

        public int LanceLeDe()
        {
            return de.LanceLeDe();
        }
    }
}
