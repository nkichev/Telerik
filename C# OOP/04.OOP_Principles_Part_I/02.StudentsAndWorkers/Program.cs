using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student> {
                new Student("Peter","Georgiev",3),
                new Student("Dobri","Petrov",5),
                new Student("Dilqn","Vasilev",4),
                new Student("Stefan","Ivanov",6),
                new Student("Ivo","Andonov",5),
            };

            studentsList = studentsList.OrderByDescending(student => student.Grade).ToList();
            foreach (Student student in studentsList)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Grade);
            }
            Console.WriteLine();

            List<Worker> workersList = new List<Worker>{
                new Worker("Donko","Vasilev",600,8),
                new Worker("Ivan","Stoqnov",300,4),
                new Worker("Vasil","Petkov",500,8),
                new Worker("Petar","Pavlov",390,6),
                new Worker("Tihomir","Arabadjiev",200,3),
                new Worker("Stefan","Minev",650,8),
            };
            workersList = workersList.OrderByDescending(worker => worker.MoneyPerHour()).ToList();
            foreach (Worker worker in workersList)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker.MoneyPerHour());
            }
            Console.WriteLine();

            var mergedlists = workersList.Concat<Human>(studentsList).ToList();
            mergedlists = mergedlists.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            foreach (Human human in mergedlists.OrderBy(human => human.FirstName).ThenBy(human => human.LastName))
            {
                Console.WriteLine(human.FirstName + " " + human.LastName + "-" + human.GetType());
            }
        }
    }
}
