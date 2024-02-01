namespace _10_Template
{
    abstract class BeverageTemplate
    {
        // Template method
        public void MakeBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        // Abstract methods to be implemented by subclasses
        protected abstract void BoilWater();
        protected abstract void Brew();
        protected abstract void PourInCup();
        protected abstract void AddCondiments();
    }
}
