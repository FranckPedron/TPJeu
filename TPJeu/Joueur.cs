using System;
using System.Collections.Generic;
using System.Text;

namespace TPJeu
{
    class Joueur
    {
        private De de;
        public int PtsVie { get; private set; }
        public bool EstVivant
        {
            get 
            {
                return PtsVie>0;
            }
        }

        public Joueur(int points)
        {
            PtsVie = points;
            de=new De();
        }


        public void Attaque(Monstre monstre)
        {
            int lanceDeJoueur=this.LanceLeDe();
            int lanceDeMonstre=monstre.LanceleDe();

            if(lanceDeJoueur>=lanceDeMonstre){
                monstre.SubitDegats();
            }
        }

        public void SubitDegats(int degatsSubits)
        {
            if (!BouclierFonctionne())
            PtsVie-=degatsSubits;
        }

        private BouclierFonctionne(){
            return de.LanceLeDe()<=2;
        }
        
        public int LanceLeDe(){
        return de.LanceLeDe();
        }
    }
}
