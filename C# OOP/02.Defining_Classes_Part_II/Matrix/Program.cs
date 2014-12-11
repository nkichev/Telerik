using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Matrix<int> myMatrix = new Matrix<int>(2, 2);
        Matrix<int> yourMatrix = new Matrix<int>(2, 2);
        myMatrix[0, 0] = 1;
        myMatrix[0, 1] = 2;
        myMatrix[1, 0] = 3;
        myMatrix[1, 1] = 4;

        yourMatrix[0, 0] = 1;
        yourMatrix[0, 1] = 2;
        yourMatrix[1, 0] = 3;
        yourMatrix[1, 1] = 4;

        Console.WriteLine(myMatrix.ToString());
        Console.WriteLine(yourMatrix.ToString());

        Console.WriteLine((myMatrix + yourMatrix).ToString());

        Console.WriteLine((myMatrix - yourMatrix).ToString());

        Matrix<int> firstMatrix = new Matrix<int>(3, 2);
        Matrix<int> secondMatrix = new Matrix<int>(2, 2);
        firstMatrix[0, 0] = 1;
        firstMatrix[0, 1] = 3;
        firstMatrix[1, 0] = 0; 
        firstMatrix[1, 1] = -2;
        firstMatrix[2, 0] = 4;
        firstMatrix[2, 1] = 1;

        secondMatrix[0, 0] = 7;
        secondMatrix[0, 1] = 9;
        secondMatrix[1, 0] = 5;
        secondMatrix[1, 1] = 2;

        Console.WriteLine((firstMatrix * secondMatrix).ToString());

        if (firstMatrix)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

