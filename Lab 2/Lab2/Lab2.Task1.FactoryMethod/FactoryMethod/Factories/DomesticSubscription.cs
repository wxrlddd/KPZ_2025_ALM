using System;

namespace FactoryMethod.Factories
{
    public class DomesticSubscription : Subscription
    {
        public override void Subscribe()
        {
            Console.WriteLine("Підписка на внутрішні канали активована");
        }

        public override decimal GetMonthlyPrice() => 150;
    }
}
