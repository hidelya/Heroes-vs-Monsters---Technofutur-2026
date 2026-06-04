using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboHeroesVsMonster.Class
{
    
    public abstract class Perso
    {
        public int end { get; protected set; }
        public int forc { get; protected set; }
        public int Pv { get; set; }
        private int _pvMax;

        public int PvMax
        {
            get { return _pvMax; }
            protected set { _pvMax = value; }
        }
        
        public int Cuir { get; set; }
        public int Or { get; set; }

        public int placementX { get; set; }
        public int placementY { get; set; }
        public Perso()
        {
           end = PointEndurance();
           forc = PointForce();
           PvMax = PointVie();
           Pv = PvMax;
           Cuir = 0;
           Or = 0;
           placementX = PlacementX();
           placementY = PlacementY();

         
           
        }

        
        public int PointEndurance()
        {
            int[] tab = {0,0,0,0 }; 
            
            for (int i=0; i<3; i++) 
            {
                Dice Endurance = new Dice(1, 6);
                tab[i] = Endurance.Lance();           
            }
            int total = tab.Sum()-tab.Min();
            return total;
        }

        public int PointForce()
        {
            int[] tab = { 0, 0, 0, 0 };

            for (int i = 0; i < 3; i++) 
            { 
            Dice Force = new Dice(1, 6);
                tab[i] = Force.Lance();
            }
            int total = tab.Sum() - tab.Min();
            return total;
        }

        public int PointVie()
        {
            Dice pv = new Dice(1, 4);
            PvMax = pv.Lance();
            if (end < 5)
            {
                PvMax -= 1;
            }
            else if (end <= 10)
            {
                PvMax -= 0;
            }
            else if (end <= 15)
            {
                PvMax += 1;
            }
            else
            {
                PvMax += 2;
            }
            return end + PvMax;
        }

        public void RestorePv()
        {
            Pv = PvMax;
        }

        Dice dice = new Dice(1, 4);
        public int Frappe()
        {   
            int degat = dice.Lance();
            return degat;
        }
        
        public static void FrappeAdversaire(Perso attaquantActuel, Perso defenseur)
        {
            int degat = attaquantActuel.Frappe();
            defenseur.Pv -= degat;
            Console.WriteLine($"C'est au tour de {attaquantActuel.GetType().Name}");
            Console.WriteLine($"{defenseur.GetType().Name} à perdu {degat} de pv ! Il lui en reste {defenseur.Pv}");


        }

        public static void Loot(Monster monstreActuel, Perso joueur, int stockCuir, int stockOr)
        {
            if (joueur.Pv > 0)
            {
                if (monstreActuel.Cuir > 0)
                {
                    stockCuir = joueur.Cuir += monstreActuel.Cuir;
                    Console.WriteLine($"Tu as récupéré {monstreActuel.Cuir}, tu en as actuellement {stockCuir} de cuir dans ton sac.");
                }
                if (monstreActuel.Or > 0)
                {
                    stockOr = joueur.Or += monstreActuel.Or;
                    Console.WriteLine($"Tu as récupéré {monstreActuel.Or}, tu as actuellement {stockOr} de cuir dans ton sac.");
                }
            }
        }

        public static void BoucleAttaque(Perso joueur, bool input, Monster monstreActuel)
        {
            while (joueur.Pv > 0 && monstreActuel.Pv > 0)
            {
                
                Utilitaires.InputDe();
                Perso.FrappeAdversaire(joueur, monstreActuel);
                if (monstreActuel.Pv <= 0) { break; }
                Utilitaires.Clear(input);
                Perso.FrappeAdversaire(monstreActuel, joueur);
                Utilitaires.Clear(input);

            }
            if (joueur.Pv > 0)
            {
                Console.WriteLine("Tu as gagné ce tour !");

            }
        }

        public static int PlacementX()
        {   int n = 0;
            do
            {   n += 2;
                return n;
            } while (n < 10);
            
        }
        public static int PlacementY()
        {
            int n = 0;
            do
            {
                n += 2;
                return n;
            } while (n < 10);
        }
    }
}
