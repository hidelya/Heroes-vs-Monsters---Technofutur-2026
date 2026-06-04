using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboHeroesVsMonster.Class
{
    public class Dice
    {
        public int min;
        public int max;
        public Dice(int min, int max) 
        {
            this.min = min;
            this.max = max;

        }

        public int Lance()
        {
            return Random.Shared.Next(min, max+1);
            
            
        }
        
    }
}
