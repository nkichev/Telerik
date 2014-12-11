//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinSearchForLargestNum
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K = ");
        int K = int.Parse(Console.ReadLine());

        int[] theArray = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("theArray[{0}] = ", i);
            theArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(theArray);

        int searchedNum = Array.BinarySearch(theArray, K);

        Console.WriteLine("After sorting the array looks like :");

        foreach (var item in theArray)
        {
            Console.Write(item + " ");  
        }
        Console.WriteLine();


        if (searchedNum < -1)
        {
            //Using the logic that "~searchedNum" returns the index of the first element bigger than searchedNum so whith "~searchedNum - 1" we find the biggest element lower than searchedNum.
            Console.WriteLine("Largest number lower than {0} is {1}", K, theArray[~searchedNum - 1]); 
        }
        else if (~searchedNum == 0)
        {
            Console.WriteLine("No smaller or equal to element in the array.");
        }
        else
        {
            Console.WriteLine(theArray[searchedNum]);
        }

    }
}

