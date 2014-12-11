using System;

namespace Telerik.TeamProject.DealOrNoDealGame
{
    public class InputValidator
    {
        public static string ValidateName(string message)
        {
            Console.Clear();
            Console.SetCursorPosition(40, 0);
            Console.WriteLine(message);
            Console.SetCursorPosition(40, 1);
            string name = Console.ReadLine();

            while (name.Length > 20)
            {
                Console.WriteLine("That is too long. Try something shorter than 20 symbols.");
                name = Console.ReadLine();
            }

            return name;
        }

        public static byte ValidateAge(string message)
        {
            Console.WriteLine(message);
            byte age;

            while (!byte.TryParse(Console.ReadLine().Trim(), out age) || age > 100 || age < 5)
            {
                Console.WriteLine("Please eneter your correct age.");
            }

            return age;
        }

        public static int GetCorrectBoxNumber(string message)
        {
            int boxNumber = 0;
            GameGraphics.WriteAt(0, 20, message);
            Console.SetCursorPosition(0, GameGraphics.InputRow);

            while (!int.TryParse(Console.ReadLine().Trim(), out boxNumber)
                    || boxNumber < 1
                    || boxNumber > 22)
            {
                GameGraphics.ClearTextBox(); 
                GameGraphics.WriteAt(0, 21, "That is not a correct box number. Try agian.");
                Console.SetCursorPosition(0, GameGraphics.InputRow);
            }

            return boxNumber;
        }

        public static int GetCorrectBoxNumber(bool[] openedBoxes, int myBox)
        {
            int boxNumber = 0;
            bool boxUnvailable = true;

            while (boxUnvailable)
            {
                GameGraphics.ClearTextBox();
                boxNumber = GetCorrectBoxNumber("Choose box to open.");

                if (openedBoxes[boxNumber - 1])
                {
                    GameGraphics.WriteAt(0, 21, "You have already opened that box.");
                    Console.SetCursorPosition(0, GameGraphics.InputRow);
                }
                else if (myBox == boxNumber)
                {        
                    GameGraphics.WriteAt(0, 21, "You cannot open yout box, yet.");
                    Console.SetCursorPosition(0, GameGraphics.InputRow);
                }
                else
                {
                    boxUnvailable = false;
                }
            }
            
            return boxNumber;
        }
    }
}
