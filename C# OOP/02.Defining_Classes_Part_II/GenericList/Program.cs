using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        GenericList<int> myList = new GenericList<int>(4);
        myList.Add(0);
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        myList.RemoveAt(0);
        myList.Add(5);
        myList.InsertAt(9, 2);

        Console.WriteLine(myList.Min());
        Console.WriteLine(myList.Max());
    }
}
