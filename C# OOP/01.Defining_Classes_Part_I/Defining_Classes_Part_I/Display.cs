using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{
    public class Display
    {
        // Fields
        private int size;
        private int numberofColors;

        //Properties
        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public int NumberofColors
        {
            get { return this.numberofColors; }
            set { this.numberofColors = value; }
        }

        //Constructors
        public Display()
            : this(0, 0)
        {
        }
        public Display(int size, int numberofColors)
        {
            this.Size = size;
            this.NumberofColors = numberofColors;
        }

    }
}