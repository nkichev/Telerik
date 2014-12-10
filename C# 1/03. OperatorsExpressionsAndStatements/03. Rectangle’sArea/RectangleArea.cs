//Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea 
{
    static void Main()
    {
        Console.Write("Enter width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());
        int area = width * height;
        Console.WriteLine("Rectangle's area = {0}", area);
    }
}

