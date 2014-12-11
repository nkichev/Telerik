using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Discipline : ICommentable
    {
        private int numberOfLectures;
        private int numberOfExercises;

        public string Name { get; set; }
        public string Comment { get; set; }
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }
        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public override string ToString()
        {
            return string.Format("{0} - lectures: {1}, exercises: {2}", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
