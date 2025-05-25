using System;

namespace FactoryMethod.Factories
{
    public abstract class SubscriptionCreator
    {
        public abstract Subscription CreateSubscription();

        public void ProcessSubscription()
        {
            var subscription = CreateSubscription();
            subscription.Subscribe();
            Console.WriteLine($"Місячна плата: {subscription.GetMonthlyPrice()} грн");
        }
    }
}
