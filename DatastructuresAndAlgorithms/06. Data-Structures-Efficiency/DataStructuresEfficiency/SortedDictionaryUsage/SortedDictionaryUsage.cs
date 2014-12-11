namespace SortedDictionaryUsage
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Wintellect.PowerCollections;

    public class SortedDictionaryUsage
    {
        /* 01. A text file students.txt holds information about students and their courses in the following format:
        Kiril  | Ivanov   | C#
        Stefka | Nikolova | SQL
        Stela  | Mineva   | Java
        Milena | Petrova  | C#
        Ivan   | Grigorov | C#
        Ivan   | Kolev    | SQL
        Using SortedDictionary<K,T> print the courses in alphabetical order and for each of them prints the students ordered by family and then by name:
        C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
        Java: Stela Mineva
        SQL: Ivan Kolev, Stefka Nikolova
        * 
        */

        private static SortedDictionary<string, OrderedBag<Student>> courses = new SortedDictionary<string, OrderedBag<Student>>();

        public static void Main()
        {
            using (StreamReader sr = new StreamReader("../../students.txt"))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    ParseLine(line);
                    line = sr.ReadLine();
                }
            }

            PrintCourses();
        }
  
        private static void PrintCourses()
        {
            foreach (var course in courses)
            {
                Console.Write(course.Key + ": ");
                for (int i = 0; i < course.Value.Count; i++)
                {
                    if (i == course.Value.Count - 1)
                    {
                        Console.WriteLine(course.Value[i]);
                    }
                    else
                    {
                        Console.Write(course.Value[i] + ", ");
                    }
                }
            }
        }

        private static void ParseLine(string line)
        {
            string[] data = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
            string firstName = data[0];
            string lastName = data[1];
            string course = data[2];

            SaveDataToDictitonary(firstName, lastName, course);
        }

        private static void SaveDataToDictitonary(string firstName, string lastName, string course)
        {
            if (courses.ContainsKey(course))
            {
                courses[course].Add(new Student(firstName, lastName));
            }
            else
            {
                courses[course] = new OrderedBag<Student> { new Student(firstName, lastName) };
            }
        }
    }
}