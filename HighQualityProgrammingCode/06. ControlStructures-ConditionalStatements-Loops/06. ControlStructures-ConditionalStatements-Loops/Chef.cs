namespace ControlStructuresConditionalStatementsLoops
{
    using System;
    using System.Linq;

    internal class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Cut(potato);
            Peel(carrot);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            Bowl bowl = new Bowl();

            return bowl;
        }

        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();

            return carrot;
        }

        private Potato GetPotato()
        {
            Potato potato = new Potato();

            return potato;
        }

        private void Cut(Vegetable vegetable)
        {
        }

        private void Peel(Vegetable vegetable) 
        {
        }
    }
}