using System;

namespace AbstractFactory.Factories
{
    public class Laptop : Device
    {
        public override void Display()
            => Console.WriteLine("Дисплей ноутбука активний");

        public override void PowerOn()
            => Console.WriteLine("Ноутбук увімкнено");
    }
}
