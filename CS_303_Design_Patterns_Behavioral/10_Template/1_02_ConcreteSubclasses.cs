namespace _10_Template
{
    class Tea : BeverageTemplate
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Boiling water for tea");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void PourInCup()
        {
            Console.WriteLine("Pouring tea into cup");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon for tea");
        }
    }

    class Coffee : BeverageTemplate
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Boiling water for coffee");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee grounds");
        }

        protected override void PourInCup()
        {
            Console.WriteLine("Pouring coffee into cup");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk for coffee");
        }
    }

}
