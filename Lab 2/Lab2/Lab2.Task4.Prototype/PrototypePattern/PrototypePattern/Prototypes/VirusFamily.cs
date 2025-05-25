using System;
using System.Collections.Generic;

namespace PrototypePattern.Prototypes
{
    public class VirusFamily
    {
        private readonly Dictionary<string, VirusPrototype> prototypes = new Dictionary<string, VirusPrototype>();

        public VirusFamily()
        {
            var covid = new Virus("COVID-19", 4, "Респіраторний", 0.001);
            covid.Children.Add(new Virus("Alpha", 1, "Варіант", 0.0008));
            covid.Children.Add(new Virus("Delta", 2, "Варіант", 0.0009));
            covid.Children.Add(new Virus("Omicron", 1, "Варіант", 0.0007));

            prototypes["COVID-19"] = covid;
            prototypes["Influenza"] = new Virus("H1N1", 10, "Грип", 0.002);
            prototypes["CommonCold"] = new Virus("Rhinovirus", 50, "Застуда", 0.0005);
        }

        public void ShowAvailableTypes()
        {
            Console.WriteLine("Доступні типи вірусів:");
            foreach (var key in prototypes.Keys)
                Console.WriteLine($"- {key}");
        }

        public VirusPrototype CloneVirus(string key)
            => prototypes.ContainsKey(key) ? prototypes[key].Clone() : null;
    }
}
