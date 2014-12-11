using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructuresConditionalStatementsLoops
{
    class IfStatements
    {
        public void CookPotato(Potato potato)
        {
            if (potato != null && potato.hasBeenPeeled && !potato.isRotten)
            {
                //Cook(potato);
            }
        }

        public void VisitingCell()
        { 
            //if (inRange(x, MIN_X, MAX_X) && inRange(y, MIN_Y, MAX_Y) && shouldVisitCell)))
            //{
            //   VisitCell();
            //}
        }

        public bool inRange(int value, int min, int max)
        {
            return min <= value && value <= max;
        }
    }
}
