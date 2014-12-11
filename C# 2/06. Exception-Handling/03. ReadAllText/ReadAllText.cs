//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;
using System.Text;

class ReadAllText
{
    static void Main()
    {
        Console.Write("Enter the path of the file you want to read from: ");
        string path = Console.ReadLine();

        // Open the file to read from. 
        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }

        catch (ArgumentException)
        {
            Console.WriteLine("The file path is not correct.");
        }

        catch (PathTooLongException)
        {
            Console.WriteLine("The file path is too long.");
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
        }

        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }

        catch (SecurityException)
        {
            Console.WriteLine("You don't have the permission to access this file.");
        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory cannot be found");
        }
    }
}

