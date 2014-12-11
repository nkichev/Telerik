using System;
using System.Threading;

namespace Telerik.TeamProject.DealOrNoDealGame
{
    public class DealGame
    {
        static void Main()
        {
            StartDealGame();
        }

        private static void StartDealGame()
        {
            Sounds.SetUpAidio();

            Console.Title = ("DEAL OR NO DEAL GAME");
            GameGraphics.SetConsoleSize(100, 30, 100, 30);
            Console.CursorVisible = false;

            // INTRO
            // Rules, player name, small talk
            Sounds.PlayIntroMusic();
            GameGraphics.WriteAt(36, 0, "This is \"Deal or no deal\" game.");
            Thread.Sleep(2000);
            Player currentPlayer = new Player();
            Console.Clear();

            Sounds.PlayGameMusic();
            Boxes newGameBoxes = new Boxes();
            GameGraphics.DrawStrings();
            GameGraphics.DrawBoxes();
            GameGraphics.DrawSums();
            newGameBoxes.ChooseBox();

            // ROUND 1
            // Open 5 boxes
            GameGraphics.WriteAt(36, 19, "Round one - you will open five boxes.");
            newGameBoxes.OpenBoxes(5);
            // Price Offer
            if (newGameBoxes.TakeOfferPrice(currentPlayer.Name))
            {
                return;
            }

            Sounds.PlayGameMusic();
            // ROUND 2
            // open 3 boxes
            GameGraphics.WriteAt(36, 19, "Round two - 17 boxes left. Open three more boxes.");
            newGameBoxes.OpenBoxes(3);
            // Price Offer
            if (newGameBoxes.TakeOfferPrice(currentPlayer.Name))
            {
                return;
            }

            Sounds.PlayGameMusic();
            // ROUND 3
            // open 3 boxes
            GameGraphics.WriteAt(36, 19, "Round three - 14 boxes left. Open three more boxes.");
            newGameBoxes.OpenBoxes(3);
            // Price Offer
            if (newGameBoxes.TakeOfferPrice(currentPlayer.Name))
            {
                return;
            }

            Sounds.PlayGameMusic();
            // ROUND 4
            // open 3 boxes
            GameGraphics.WriteAt(36, 19, "Round four - 11 boxes left. Open three more boxes.");
            newGameBoxes.OpenBoxes(3);
            // Price Offer
            if (newGameBoxes.TakeOfferPrice(currentPlayer.Name))
            {
                return;
            }

            Sounds.PlayGameMusic();
            // ROUND 5
            // open 3 boxes
            GameGraphics.WriteAt(36, 19, "Round five - 8 boxes left. Open three more boxes.");
            newGameBoxes.OpenBoxes(3);
            // Price Offer
            if (newGameBoxes.TakeOfferPrice(currentPlayer.Name))
            {
                return;
            }

            Sounds.PlayGameMusic();
            // ROUND 6
            // open 3 boxes
            GameGraphics.WriteAt(36, 19, "Round six - 5 boxes left. Open three more boxes.");
            newGameBoxes.OpenBoxes(3);
            // Price Offer
            if (newGameBoxes.TakeOfferPrice(currentPlayer.Name))
            {
                return;
            }

            Sounds.PlayThinkingMusic();
            // ROUND 7 FINAL ROUND
            GameGraphics.ClearTextBox();
            GameGraphics.WriteAt(36, 19, "Final Rownd - 2 boxes left.");
            // Swap Offer
            newGameBoxes.SwapBoxes();
            // Open last two boxes
            newGameBoxes.OpenLastTwoBoxes(currentPlayer.Name);
            // Enter highscore

            // END GAME
        }
    }
}
