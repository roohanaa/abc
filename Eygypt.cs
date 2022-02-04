using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    internal class Eygypt
    {
        int guess1,guess2,guess3;

        public Eygypt(int guess1, int guess2, int guess3)
        {
            this.guess1 = guess1;
            this.guess2 = guess2;
            this.guess3 = guess3;
        }

        public string perfectsquare()
        {
            int temphypotneus = (guess1 * guess1)+(guess2 * guess2)  ;
            if (temphypotneus == 0)
            {
                return null;
            }
            if ((guess3 * guess3) == temphypotneus)
            {
                return "right";
            }
            
            else
            {
                return "wrong";
            }
        }
    }
}
