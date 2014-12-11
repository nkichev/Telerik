using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Student : Person
    {
        private int uniqueNum;

        public int UniqueNum
        {
            get { return this.uniqueNum; }
            set { this.uniqueNum = value; }
        }

        public Student(string name, int uniqueNum)
            : base(name)
        {
            this.UniqueNum = uniqueNum;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Name, this.UniqueNum);
        }
    }
}
