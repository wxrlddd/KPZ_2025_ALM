using System;

namespace FactoryMethod.Factories
{
    public class EducationalSubscription : Subscription
    {
        public override void Subscribe()
        {
            Console.WriteLine("Освітня підписка активована");
        }

        public override decimal GetMonthlyPrice() => 100;
    }
}
