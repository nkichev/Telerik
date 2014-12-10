//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class ObjectVar
{
    static void Main()
    {
        string firstStr = "Hello,";
        string secondStr = "World!";
        object concatenation = (firstStr + " " + secondStr);
        string thirdStr = (string) concatenation;
        Console.WriteLine(thirdStr);
    }
}

