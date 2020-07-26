using System;
using System.Collections.Generic;
using System.Text;

namespace TPJeu
{
    class MonstreDifficile:MonstreFacile
    {
        private int degatsSort=5;

        public override void Attaque(Joueur joueur)
        {
             base.Attaque(joueur);   
            joueur.SubitDegats(SortMagique());
        }
  
        private int SortMagique(){
        int valeur=de.LanceLeDe();
            if(valeur==6)
                return 0;
            return degatsSort*valeur;
        }
    }
}
