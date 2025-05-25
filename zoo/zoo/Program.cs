using System;
using System.Collections.Generic;
using System.Text;
using ZooLab.Interfaces;
using ZooLab.Models;
using ZooLab.Services;

namespace ZooLab;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var animals = new List<Animal>
        {
            new Animal("Лео", "Лев", "Африканський лев", 5),
            new Animal("Тигра", "Тигр", "Бенгальський тигр", 3),
            new Animal("Белла", "Білий ведмідь", "Арктичний ведмідь", 4)
        };

        var enclosures = new List<Enclosure>
        {
            new Enclosure("E1", 250.5, "Хижаки"),
            new Enclosure("E2", 150.0, "Ссавці")
        };
        enclosures[0].AddAnimal(animals[0]);
        enclosures[0].AddAnimal(animals[1]);
        enclosures[1].AddAnimal(animals[2]);

        var feeds = new List<Feed>
        {
            new Feed("Лев", "М\'ясо", 50),
            new Feed("Тигр", "М\'ясо", 40),
            new Feed("Білий ведмідь", "Риба", 30)
        };

        var staff = new List<Staff>
        {
            new Staff("Ольга", "Доглядач"),
            new Staff("Іван", "Ветеринарний лікар")
        };

        IReportable reporter = new InventoryReporter(animals, staff, enclosures, feeds);
        Console.WriteLine(reporter.GetReport());
    }
}
