using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Telerik.TeamProject.DealOrNoDealGame
{
    public class Boxes
    {
        // ------------------------Fields--------------------------

        public static decimal[] DefaultSums { get; set; } // Keep default sum values

        public decimal[] boxes { get; set; } // Store each sum here

        public bool[] openedBoxes { get; set; } // Keeps track of opened boxes

        public int myBox { get; set; } // This is the player's box index

        // ----------------------Constructor------------------------

        public Boxes()
        {
            Boxes.DefaultSums = new decimal[22] {0.1m, 0.2m, 0.5m, 1, 5, 10, 20, 50, 100, 200, 300,
                           750, 1000, 2500, 5000, 7500, 10000, 12500, 15000,25000, 50000, 100000};

            this.boxes = Boxes.DefaultSums;

            this.boxes = RandomizeArray(this.boxes);

            this.openedBoxes = new bool[22];
        }

        // ------------------------Methods--------------------------

        private decimal[] RandomizeArray(decimal[] inputBoxes)
        {

            Random myRandom = new Random();

            List<KeyValuePair<int, decimal>> pairedList = new List<KeyValuePair<int, decimal>>();

            // Add new random int each paired with each sum
            foreach (decimal s in inputBoxes)
            {
                pairedList.Add(new KeyValuePair<int, decimal>(myRandom.Next(30000), s));
            }

            // Sort the list by the random number
            var sorted = from item in pairedList
                         orderby item.Key
                         select item;

            // Allocate new shuffled decimal array
            decimal[] shuffledBoxes = new decimal[inputBoxes.Length];
            int index = 0;
            foreach (KeyValuePair<int, decimal> pair in sorted)
            {
                shuffledBoxes[index] = pair.Value;
                index++;
            }

            return shuffledBoxes;
        }

        public void ChooseBox()
        {
            this.myBox = InputValidator.GetCorrectBoxNumber("Choose your box.");
            GameGraphics.DeleteBox(this.myBox);
        }

        public void OpenBoxes(int boxesToOpen)
        {
            while (boxesToOpen > 0)
            {
                int openBoxNum = InputValidator.GetCorrectBoxNumber(this.openedBoxes, this.myBox);
                OpenBox(openBoxNum);
                GameGraphics.DeleteBox(openBoxNum); 
                GameGraphics.DeleteSum(this.boxes[openBoxNum - 1]);
                boxesToOpen--;
            }
        }

        public void OpenLastTwoBoxes(string name)
        {
            decimal score = this.boxes[this.myBox];
            this.openedBoxes[this.myBox] = true;

            for (int i = 0; i < 22; i++)
            {
                if (!this.openedBoxes[i])
                {
                    GameGraphics.ClearLine(21);
                    GameGraphics.WriteAt(0, 21, "Last box has " + this.boxes[i] + " levs in it.");
                    this.OpenBox(i + 1);
                    GameGraphics.ClearLine(19);
                }
            }

            Thread.Sleep(1000);
            GameGraphics.WriteAt(0, 22, "That leaves you with...");
            Thread.Sleep(1000);
            GameGraphics.WriteAt(0, 23, this.boxes[this.myBox - 1].ToString() + " levs! Congratulations " + name + "!");
            GameGraphics.WriteAt(0, 24, "...................");
            Sounds.PlayApplause();
            Thread.Sleep(3000);
        }

        private void OpenBox(int openBoxNum)
        {
            GameGraphics.ClearLine(19);
            GameGraphics.WriteAt(0, 19, this.boxes[openBoxNum - 1].ToString());
            this.openedBoxes[openBoxNum - 1] = true;
        }

        public bool TakeOfferPrice(string name)
        {
            Sounds.PlayBankOfferMusic();
            Thread.Sleep(2000); // This makes me eneter box number before question
            Sounds.PlayThinkingMusic();
            bool takeOffer = false;
            int priceOffer = CalculateOffer();
            string offer = "Ok " + name + ". We offer you " + priceOffer;

            GameGraphics.ClearLine(19);
            GameGraphics.ClearTextBox();
            GameGraphics.WriteAt(40, 19, "-----OFFER-----");
            GameGraphics.WriteAt(0, 20, offer);
            GameGraphics.WriteAt(0, 21, "What do you say. Do you take the offer? (yes/no) ");
            Console.SetCursorPosition(0, GameGraphics.InputRow);
            string answer = Console.ReadLine().Trim();

            if (answer == "yes")
            {
                GameGraphics.ClearTextBox();
                GameGraphics.WriteAt(0, 20, "You leave the game with " + priceOffer);
                Thread.Sleep(1000);
                takeOffer = true;
                Sounds.PlayApplause();
                Thread.Sleep(3000);
                // Enter hihgscore
                Highscore.EnterHighscore(priceOffer, name);
                Console.ReadLine();
            }

            return takeOffer;
        }

        private int CalculateOffer()
        {
            decimal offer = 0;
            decimal sum = 0;
            decimal divider = 0;

            for (int i = 0; i < 22; i++)
            {
                if (!this.openedBoxes[i])
                {
                    sum += this.boxes[i];
                    divider++;
                }
            }
            offer = sum / divider;

            if (divider > 15)
            {
                offer = 0.5m * offer;
            }
            else if (divider > 10)
            {
                offer = 0.6m * offer;
            }
            else if (divider > 5)
            {
                offer = 0.7m * offer;
            }
            else
            {
                offer = 0.8m * offer;
            }

            int rounded = Convert.ToInt32(offer);

            return rounded;
        }

        public void SwapBoxes()
        {
            GameGraphics.ClearLine(19);
            GameGraphics.WriteAt(0, 21, "Do you want to swap your box? (yes/no)");
            Console.SetCursorPosition(0, GameGraphics.InputRow);
            string answer = Console.ReadLine().Trim();

            if (answer == "yes")
            {
                for (int i = 0; i < 22; i++)
                {
                    if (!this.openedBoxes[i] && this.myBox != i)
                    {
                        this.myBox = i;
                    }
                }
            }
        }
    }
}
