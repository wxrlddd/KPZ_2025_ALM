namespace FactoryMethod.Factories
{
    public class WebSite : SubscriptionCreator
    {
        public override Subscription CreateSubscription() => new DomesticSubscription();
    }
}
