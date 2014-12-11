using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string name;
        private int uniqueNum;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNum = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be null");
                }
                this.name = value;
            }
        }
        public int UniqueNum
        {
            get
            {
                return this.uniqueNum;
            }
            set
            {
                if (10000 > value || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("The unique number must be between 10000 and 99999");
                }
                this.uniqueNum = value;
            }
        }
    }
}
