using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboHeroesVsMonster.Class
{
    public abstract class Utilitaires
    {
        public static bool InputDe()
        {
            Console.WriteLine("Lance le dé en appyant sur la barre d'espace !");
            Console.ReadKey();

            return true;

        }
        public static bool InputContinue()
        {
            Console.WriteLine("Appuie sur une touche pour continuer...");
            Console.ReadKey();

            return true;

        }
        public static void Clear(bool valeur)
        {
            valeur = Utilitaires.InputContinue();
            if (valeur)
            {
                Console.Clear();
                valeur = false;
            }
        }

        
    }
}
