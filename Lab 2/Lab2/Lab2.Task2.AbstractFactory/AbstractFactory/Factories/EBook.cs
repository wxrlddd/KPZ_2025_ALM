using System;

namespace AbstractFactory.Factories
{
    public class EBook : Device
    {
        public override void Display()
            => Console.WriteLine("E-ink дисплей активний");

        public override void PowerOn()
            => Console.WriteLine("E-Book увімкнено");
    }
}
