//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
//The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class AllCardsFromDeck
{
    static void Main()
    {
        for (int i = 0; i < 13; i++)
        {

            for (int j = 0; j < 4; j++)
            {
                string color = "";
                switch (j)
                {
                    case 0:
                        color = "Clubs";
                        break;
                    case 1:
                        color = "Diamonds";
                        break;
                    case 2:
                        color = "Hearts";
                        break;
                    case 3:
                        color = "Spades";
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Two of " + color);
                        break;
                    case 1:
                        Console.WriteLine("Three of " + color);
                        break;
                    case 2:
                        Console.WriteLine("Four of " + color);
                        break;
                    case 3:
                        Console.WriteLine("Five of " + color);
                        break;
                    case 4:
                        Console.WriteLine("Six of " + color);
                        break;
                    case 5:
                        Console.WriteLine("Seven of " + color);
                        break;
                    case 6:
                        Console.WriteLine("Eight of " + color);
                        break;
                    case 7:
                        Console.WriteLine("Nine of " + color);
                        break;
                    case 8:
                        Console.WriteLine("Ten of " + color);
                        break;
                    case 9:
                        Console.WriteLine("Jack of " + color);
                        break;
                    case 10:
                        Console.WriteLine("Queen of " + color);
                        break;
                    case 11:
                        Console.WriteLine("King of " + color);
                        break;
                    case 12:
                        Console.WriteLine("Ace of " + color);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }
    }
}

