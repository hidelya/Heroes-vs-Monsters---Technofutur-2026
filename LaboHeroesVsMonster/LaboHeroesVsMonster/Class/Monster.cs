using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboHeroesVsMonster.Class
{
    public class Monster : Perso
    {
        
        public Monster() : base()
        {
            
        }

        public static Monster InitialisationMonstre()
        {
            Dice newMonstre = new Dice(1, 3);
            int monstreACreer = newMonstre.Lance();

            if(monstreACreer == 1)
            {
                Monster monstre = new Loup();              
                return monstre;
                
            }
            else if (monstreACreer == 2)
            {
                Monster monstre = new Dragonnet();
                return monstre;
                
            }
            else if (monstreACreer == 3)
            {
                Monster monstre = new Orque();
                return monstre;
                
            }
            return null!;
        }

        public int NombreCuir()
        {
            Dice Cuir = new Dice(1, 4);
            return Cuir.Lance();

        }

        public int NombreOr()
        {
            Dice Or = new Dice(1, 6);
            return Or.Lance();

        }
    }
}
