using System;
using System.Collections.Generic;
using System.Threading;

namespace Telerik.TeamProject.DealOrNoDealGame
{
    public class GameGraphics
    {
        // -----------------------Fields---------------------------

        public static int InputRow = 27; // User input line number

        // ----------------------Methods---------------------------

        public static void SetConsoleSize(int bufferWidth, int bufferHeight,
                                          int windowWidth, int windowHeight)
        {
            Console.SetBufferSize(bufferWidth, bufferHeight);
            Console.SetWindowSize(windowWidth, windowHeight);
        }

        public static void ClearLine(int x, int y, int length)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < length; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(x, y);
        }

        public static void ClearLine(int lineNumber)
        {
            Console.SetCursorPosition(0, lineNumber);
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(0, lineNumber);
        }

        public static void ClearTextBox()
        {
            for (int i = 20; i < 28; i++)
            {
                ClearLine(i);
            }
        }
        
        public static void WriteAt(int x, int y, string message)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
            Console.SetCursorPosition(x, y);
        }

        public static void DrawBoxes()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            WriteAt(30, 2, "╒════╕ ╒════╕ ╒════╕ ╒════╕ ╒════╕ ╒════╕");
            WriteAt(30, 3, "│ 1  │ │ 2  │ │ 3  │ │ 4  │ │ 5  │ │ 6  │");
            WriteAt(30, 4, "└────┘ └────┘ └────┘ └────┘ └────┘ └────┘");
            WriteAt(30, 5, "╒════╕ ╒════╕ ╒════╕ ╒════╕ ╒════╕ ╒════╕");
            WriteAt(30, 6, "│ 7  │ │ 8  │ │ 9  │ │ 10 │ │ 11 │ │ 12 │");
            WriteAt(30, 7, "└────┘ └────┘ └────┘ └────┘ └────┘ └────┘");
            WriteAt(30, 8, "╒════╕ ╒════╕ ╒════╕ ╒════╕ ╒════╕ ╒════╕");
            WriteAt(30, 9, "│ 13 │ │ 14 │ │ 15 │ │ 16 │ │ 17 │ │ 18 │");
            WriteAt(30,10, "└────┘ └────┘ └────┘ └────┘ └────┘ └────┘");
            WriteAt(30,11, "       ╒════╕ ╒════╕ ╒════╕ ╒════╕       ");
            WriteAt(30,12, "       │ 19 │ │ 20 │ │ 21 │ │ 22 │       ");
            WriteAt(30,13, "       └────┘ └────┘ └────┘ └────┘       ");

            Console.ResetColor();
        }

        public static void DeleteBox(int boxNumber)
        {
            int x = 30;
            int y = 2;

            if (boxNumber > 18)
            {
                x += 7;
            }

            x += ((boxNumber - 1) % 6) * 7;
            y += ((boxNumber - 1) / 6) * 3;

            WriteAt(x, y,   "      ");
            WriteAt(x, ++y, "      ");
            WriteAt(x, ++y, "      ");
        }

        public static void DrawSums()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // Small sums on the left
            WriteAt(5, 2, "   0.10");
            WriteAt(5, 3, "   0.20");
            WriteAt(5, 4, "   0.50");
            WriteAt(5, 5, "      1");
            WriteAt(5, 6, "      5");
            WriteAt(5, 7, "     10");
            WriteAt(5, 8, "     20");
            WriteAt(5, 9, "     50");
            WriteAt(5,10, "    100");
            WriteAt(5,11, "    200");
            WriteAt(5,12, "    300");

            Console.ForegroundColor = ConsoleColor.Yellow;
            // Big sums on the right
            WriteAt(85, 2, "    750");
            WriteAt(85, 3, "  1 000");
            WriteAt(85, 4, "  2 500");
            WriteAt(85, 5, "  5 000");
            WriteAt(85, 6, "  7 500");
            WriteAt(85, 7, " 10 000");
            WriteAt(85, 8, " 12 500");
            WriteAt(85, 9, " 15 000");
            WriteAt(85,10, " 25 000");
            WriteAt(85,11, " 50 000");
            WriteAt(85,12, "100 000");

            Console.ResetColor();
        }

        public static void DeleteSum(decimal sum)
        {
            int sumIndex = Array.IndexOf(Boxes.DefaultSums, sum);
            int x = 5;
            if (sumIndex > 10)
            {
                x = 85;
            }
            int y = (sumIndex % 11) + 2;

            WriteAt(x, y, "       ");
        }    

        public static void DrawStrings()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteAt(2, 0, "SMALL SUMS:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            WriteAt(50, 0, "BOXES:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteAt(85, 0, "BIG SUMS:");
            Console.ResetColor();
        }
    }
}
