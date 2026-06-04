using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboHeroesVsMonster.Class
{
    public class ZoneJeu
    {
        string[,] tab = new string[15,15] ;

        public void AfficherTableau() 
        { 
            for (int x = 0; x < tab.GetLength(0); x++)
            {
                for (int y = 0; y < tab.GetLength(1); y++)
                {
                    
                    Console.Write(tab[x,y] + "|" + "__");
                }
                Console.WriteLine();
            }
        }

        
    }
}
