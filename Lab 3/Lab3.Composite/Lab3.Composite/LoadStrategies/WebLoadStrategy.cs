using System;

namespace Lab3.Composite.LoadStrategies
{
    public class WebLoadStrategy : ILoadStrategy
    {
        public void Load(string href)
        {
            Console.WriteLine($"[Web] Завантаження з мережі: {href}");
        }
    }
}
