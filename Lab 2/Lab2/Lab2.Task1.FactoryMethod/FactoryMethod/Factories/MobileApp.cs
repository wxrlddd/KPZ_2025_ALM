namespace FactoryMethod.Factories
{
    public class MobileApp : SubscriptionCreator
    {
        public override Subscription CreateSubscription() => new PremiumSubscription();
    }
}
