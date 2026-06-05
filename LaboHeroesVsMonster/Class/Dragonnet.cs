using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboHeroesVsMonster.Class
{
    public class Dragonnet : Monster
    {
        public Dragonnet() 
        {
            Or = NombreOr();
            Cuir = NombreCuir();
            end += 1;
        }
    }
}
