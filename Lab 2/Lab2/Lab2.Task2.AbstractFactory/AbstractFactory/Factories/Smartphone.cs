using System;

namespace AbstractFactory.Factories
{
    public class Smartphone : Device
    {
        public override void Display()
            => Console.WriteLine("Сенсорний екран смартфона активний");

        public override void PowerOn()
            => Console.WriteLine("Смартфон увімкнено");
    }
}
