using System;

namespace TPJeu
{
    class Program
    {
       private static Random random = new Random();


        static void Main(string[] args)
        {
            Jeu1();
        }

        private static void Jeu1()
        {
            Joueur franck = new Joueur(150);
            int nbMonstreFacile = 0;
            int nbMonstreDif = 0;

            while (franck.EstVivant)
            {
                MonstreFacile monstre = FabriqueMonstre();
                while (monstre.EstVivant && franck.EstVivant)
                {
                    franck.Attaque(monstre);
                    if (monstre.EstVivant)
                        monstre.Attaque(franck);
                }

                if (franck.EstVivant)
                {
                    if (monstre is MonstreDifficile)
                        nbMonstreDif++;
                    else 
                        nbMonstreFacile++;
                }

                else
                {
                    Console.WriteLine("Désolé, vous êtes mort");
                    break;
                }

            }
            Console.WriteLine("Bravo !! vous avez tué {0} monstres faciles et {1} monstres difficiles. Vous avez {2} points.", nbMonstreFacile, nbMonstreDif, nbMonstreFacile + nbMonstreDif * 2);
        }

        private static MonstreFacile FabriqueMonstre()
        {
            if (random.Next(2)==0)
                return new MonstreFacile();
            else
            return new MonstreDifficile();
        }
    }
}
