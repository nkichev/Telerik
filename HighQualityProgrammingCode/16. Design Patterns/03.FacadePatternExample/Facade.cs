namespace _03.FacadePatternExample
{
    using System;

    public class Facade
    {
        private BathroomSystem bathroomSys;
        private ClothingSystem clothingSys;
        private FoodSystem foodSys;
        private MediaSystem mediaSys;
        private MessagingSystem messagingSys;

        public Facade()
        {
            this.bathroomSys = new BathroomSystem();
            this.clothingSys = new ClothingSystem();
            this.foodSys = new FoodSystem();
            this.mediaSys = new MediaSystem();
            this.messagingSys = new MessagingSystem();
        }

        public void MorningTasks()
        {
            this.messagingSys.MorningMessage();
            this.mediaSys.TurnMusicOn();
            this.bathroomSys.WarmWater();
            this.clothingSys.IronClothes();
            this.foodSys.PrepareBreakfast();
        }

        public void EveningTasks()
        {
            this.messagingSys.EveningMessage();
            this.bathroomSys.WarmWater();
            this.foodSys.PrepareDinner();
            this.mediaSys.TurnTVOn();
        }
    }
}
