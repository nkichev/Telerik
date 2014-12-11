using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructuresConditionalStatementsLoops
{
    internal class Bowl
    {
        private List<Vegetable> list = new List<Vegetable>();

        public void Add(Vegetable vegetable)
        {
            list.Add(vegetable);
        }
    }
}
