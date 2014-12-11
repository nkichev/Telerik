using System;
using System.IO;

namespace Telerik.TeamProject.DealOrNoDealGame
{
    class Highscore
    {
        public static void EnterHighscore(int score, string name)
        {
            using (StreamWriter myWriter = new StreamWriter(@"../../highscore.txt", true))
            {
                myWriter.WriteLine(score + " - " + name);
            }
        }

        public static string GetHighscore()
        {
            string highscore = "";
            try
            {
                using (StreamReader myReader = new StreamReader("highscore.txt"))
                {
                    highscore = myReader.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Cannot find this file.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Cannot read the file.");
            }
            return highscore;
        }
    }
}
