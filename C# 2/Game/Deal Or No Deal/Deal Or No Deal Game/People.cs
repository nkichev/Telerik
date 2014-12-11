using System;

namespace Telerik.TeamProject.DealOrNoDealGame
{
    public class People
    {
        public string Name { get; set; }

        public byte Age { get; set; }

        public string HomeTown { get; set; }
    }

    public class Player : People
    {
        public int Score { get; set; }

        public Player(string name, int age, string homeTown)
        {
        }

        public Player()
        {
            Console.SetCursorPosition(36, 1);
            this.Name = InputValidator.ValidateName("What is your name?");
            //this.Age = InputValidator.ValidateAge("How old are you?");
            Console.SetCursorPosition(36, 1);
            this.HomeTown = InputValidator.ValidateName("Where are you from?");
            this.Score = 0;
        }
    }
}
