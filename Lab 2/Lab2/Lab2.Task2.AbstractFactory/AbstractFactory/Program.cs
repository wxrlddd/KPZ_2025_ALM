using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Завдання 2: Абстрактна фабрика ===");

            DeviceFactory[] factories = {
                new IProneFactory(),
                new KiaomaFactory(),
                new BalaxyFactory()
            };

            foreach (var factory in factories)
            {

                string name;
                if (factory is IProneFactory) name = "IProne";
                else if (factory is KiaomaFactory) name = "Kiaoma";
                else if (factory is BalaxyFactory) name = "Balaxy";
                else name = factory.GetType().Name;


                Console.WriteLine($"\n— Бренд: {name} —");

                var laptop = factory.CreateLaptop();
                laptop.PowerOn();
                laptop.Display();

                var phone = factory.CreateSmartphone();
                phone.PowerOn();
                phone.Display();
            }
        }
    }
}
