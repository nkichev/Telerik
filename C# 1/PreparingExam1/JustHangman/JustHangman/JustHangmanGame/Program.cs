using System;

class Program
{
    static void Main(string[] args)
    {
        //champion
        char c = 'c';
        char h = 'h';
        char a = 'a';
        char m = 'm';
        char p = 'p';
        char i = 'i';
        char o = 'o';
        char n = 'n';

        char hiddenChar = '_';

        bool isCShown = false;
        bool isHShown = false;
        bool isAShown = false;
        bool isMShown = false;
        bool isPShown = false;
        bool isIShown = false;
        bool isOShown = false;
        bool isNShown = false;

        int livesCount = 3;


        Console.WriteLine("_ _ _ _ _ _ _ _");
        while (true)
        {
            Console.Write("Enter command: ");
            string command = "";
            command = Console.ReadLine();

            

            if (command == "view")
            {
                Console.WriteLine("Your lives are {0}",
                    livesCount);
            }

            if (command == "guess")
            {
                Console.Write("Enter letter: ");
                char letter = Char.Parse(Console.ReadLine());

                if (letter == c)
                {
                    if (!isCShown)
                    {
                        isCShown = true;
                    }
                    else
                    {
                        Console.WriteLine
                            ("You already revealed this letter");
                    }
                }

                if (letter == h)
                {
                    if (!isHShown)
                    {
                        isHShown = true;
                    }
                    else
                    {
                        Console.WriteLine
                            ("You already revealed this letter");
                    }
                }

                if (letter == a)
                {
                    if (!isAShown)
                    {
                        isAShown = true;
                    }
                    else
                    {
                        Console.WriteLine
                            ("You already revealed this letter");
                    }
                }
                if (letter == m)
                {
                    if (!isMShown)
                    {
                        isMShown = true;
                    }
                    else
                    {
                        Console.WriteLine
                            ("You already revealed this letter");
                    }
                }
                if (letter == p)
                {
                    if (!isPShown)
                    {
                        isPShown = true;
                    }
                    else
                    {
                        Console.WriteLine
                            ("You already revealed this letter");
                    }
                }

                if (letter == i)
                {
                    if (!isIShown)
                    {
                        isIShown = true;
                    }
                    else
                    {
                        Console.WriteLine
                            ("You already revealed this letter");
                    }
                }

                if (letter == o)
                {
                    if (!isOShown)
                    {
                        isOShown = true;
                    }
                    else
                    {
                        Console.WriteLine
                            ("You already revealed this letter");
                    }
                }

                if (letter == n)
                {
                    if (!isNShown)
                    {
                        isNShown = true;
                    }
                    else
                    {
                        Console.WriteLine
                            ("You already revealed this letter");
                    }
                }

                if (letter != c && letter != h && letter != a &&
                    letter != m && letter != p && letter != i &&
                    letter != o && letter != n)
                {
                    livesCount--;
                    Console.WriteLine("You made a huuuuuge mistake! Your lives now are {0}", livesCount);
                }

                if (livesCount == 0)
                {
                    Console.Clear();
                    isCShown = false;
                    isHShown = false;
                    isAShown = false;
                    isMShown = false;
                    isPShown = false;
                    isIShown = false;
                    isOShown = false;
                    isNShown = false;
                    livesCount = 9;

                    Console.WriteLine("Game over! Try again");

                }

                if (isCShown)
                {
                    Console.Write("{0} ", c);
                }
                else
                {
                    Console.Write("{0} ", hiddenChar);
                }

                if (isHShown)
                {
                    Console.Write("{0} ", h);
                }
                else
                {
                    Console.Write("{0} ", hiddenChar);
                }

                if (isAShown)
                {
                    Console.Write("{0} ", a);
                }
                else
                {
                    Console.Write("{0} ", hiddenChar);
                }

                if (isMShown)
                {
                    Console.Write("{0} ", m);
                }
                else
                {
                    Console.Write("{0} ", hiddenChar);
                }

                if (isPShown)
                {
                    Console.Write("{0} ", p);
                }
                else
                {
                    Console.Write("{0} ", hiddenChar);
                }

                if (isIShown)
                {
                    Console.Write("{0} ", i);
                }
                else
                {
                    Console.Write("{0} ", hiddenChar);
                }
                if (isOShown)
                {
                    Console.Write("{0} ", o);
                }
                else
                {
                    Console.Write("{0} ", hiddenChar);
                }

                if (isNShown)
                {
                    Console.Write("{0} ", n);
                }
                else
                {
                    Console.Write("{0} ", hiddenChar);
                }
                Console.WriteLine();

                if(isCShown && isHShown && isAShown &&
                    isMShown && isPShown && isIShown
                    &&isOShown && isNShown)
                {
                    isCShown = false;
                    isHShown = false;
                    isAShown = false;
                    isMShown = false;
                    isPShown = false;
                    isIShown = false;
                    isOShown = false;
                    isNShown = false;
                    livesCount = 9;
                    Console.Clear();
                    Console.WriteLine("Great job! You won!");
                }
            }

            if(command == "restart")
            {
                Console.WriteLine("Do you really want to restart?");
                Console.WriteLine("If yes press Ctrl + O");
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Modifiers == ConsoleModifiers.Control &&
                    key.Key == ConsoleKey.O)
                {
                    isCShown = false;
                    isHShown = false;
                    isAShown = false;
                    isMShown = false;
                    isPShown = false;
                    isIShown = false;
                    isOShown = false;
                    isNShown = false;
                    livesCount = 9;
                    Console.Clear();
                    Console.WriteLine("You just restarted the game!");
                    Console.WriteLine("Now you can start again guessing!");
                }
            }
        }
    }
}