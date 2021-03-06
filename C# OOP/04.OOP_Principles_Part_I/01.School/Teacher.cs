﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Teacher : Person
    {
        public List<Discipline> Disciplines { get; set; }

        public Teacher(string name)
            : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(" Disciplines: ");
            foreach (var discipline in Disciplines)
            {
                sb.Append(discipline + ", ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}
