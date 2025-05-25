using System;

namespace FactoryMethod.Factories
{
    public class PremiumSubscription : Subscription
    {
        public override void Subscribe()
        {
            Console.WriteLine("Преміум підписка активована");
        }

        public override decimal GetMonthlyPrice() => 300;
    }
}
