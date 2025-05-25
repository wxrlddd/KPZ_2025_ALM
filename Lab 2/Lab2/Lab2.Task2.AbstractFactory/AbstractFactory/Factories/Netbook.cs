using System;

namespace AbstractFactory.Factories
{
    public class Netbook : Device
    {
        public override void Display()
            => Console.WriteLine("Дисплей нетбука активний");

        public override void PowerOn()
            => Console.WriteLine("Нетбук увімкнено");
    }
}
