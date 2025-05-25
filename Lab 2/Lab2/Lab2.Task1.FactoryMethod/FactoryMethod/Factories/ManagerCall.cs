namespace FactoryMethod.Factories
{
    public class ManagerCall : SubscriptionCreator
    {
        public override Subscription CreateSubscription() => new EducationalSubscription();
    }
}
