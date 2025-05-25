namespace FactoryMethod.Factories
{
    public abstract class Subscription
    {
        public abstract void Subscribe();
        public abstract decimal GetMonthlyPrice();
    }
}
