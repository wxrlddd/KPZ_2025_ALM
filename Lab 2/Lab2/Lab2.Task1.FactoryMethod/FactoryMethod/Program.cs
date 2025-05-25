using System;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Фабричний метод ===");

            SubscriptionCreator[] creators = {
                new WebSite(),
                new MobileApp(),
                new ManagerCall()
            };

            foreach (var creator in creators)
            {
                Console.WriteLine($"\n{creator.GetType().Name}:");
                creator.ProcessSubscription();
            }
        }
    }
}
