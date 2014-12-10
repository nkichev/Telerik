using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Vyvedi kolko e typa: ");
        int iq = int.Parse(Console.ReadLine());


        if (iq < 0)
        {
            Console.WriteLine("Boginq e");
        }

        else if (iq >= 80)
        {
            Console.WriteLine("Bate mnogo e umna za teb!");
        }
        else
        {
            Console.Write("Vyvedi cveta na kosata i: ");
            string hairColor;
            hairColor = Console.ReadLine();

            if (iq < 40)
            {
                if (hairColor == "blonde")
                {
                    Console.WriteLine("zimai q za jena");
                }
                else if (hairColor == "black")
                {
                    Console.WriteLine("Predloji i");
                }
                else if (hairColor == "red")
                {
                    Console.WriteLine("Blyskai s neq v zalata");
                }
                else
                {
                    Console.WriteLine("Begai ama byrzo");
                }
            }
            else
            {
                if (hairColor == "blonde")
                {
                    Console.WriteLine("zimai q na kafe");
                }
                else if (hairColor == "black")
                {
                    Console.WriteLine("Vodi me v nqkoqkvartalna krychma");
                }
                else if (hairColor == "red")
                {
                    Console.WriteLine("Vlizai vyv filma s neq");
                }
                else
                {
                    Console.WriteLine("Poogledai q");
                }
            }

        }
    }
}

