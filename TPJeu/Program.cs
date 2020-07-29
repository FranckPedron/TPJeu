using System;

namespace TPJeu
{
    class Program
    {
       private static Random random = new Random();


        static void Main(string[] args)
        {
            AfficheMenu();
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            while (consoleKeyInfo.Key != ConsoleKey.D1 && consoleKeyInfo.Key != ConsoleKey.D2 && consoleKeyInfo.Key != ConsoleKey.NumPad1 && consoleKeyInfo.Key != ConsoleKey.NumPad2)
            {
                AfficheMenu();
                consoleKeyInfo = Console.ReadKey(true);
            }
            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
                Jeu1();
            else
                Jeu2();
        }

        private static void AfficheMenu()
        {
            Console.Clear();
            Console.WriteLine("Veuillez choisir votre mode de jeu :");
            Console.WriteLine("\t1 : Contre les monstres");
            Console.WriteLine("\t2 : Contre le boss de fin");
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

        private static void Jeu2()
        {
            Joueur franck = new Joueur(150);
            BossDeFin boss = new BossDeFin(250);
           
            while (franck.EstVivant && boss.EstVivant)
            {
                franck.Attaque(boss);
                if (boss.EstVivant)
                    boss.Attaque(franck);
                Console.WriteLine("Points de vie franck: " + franck.PtsVie + "\nPoints de vie Bigboss: " + boss.PtsDeVie);

            }
            if (franck.EstVivant)
                Console.WriteLine("Bravo !!! vous avez battu le Boss !!");
            else
                Console.WriteLine("Vous avez perdu !!");
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
