using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ZooLab.Models;
using ZooLab.Services;

namespace ZooLab.Tests;

[TestClass]
public class InventoryReporterTests
{
    private List<Animal> _animals = default!;
    private List<Enclosure> _enclosures = default!;
    private List<Feed> _feeds = default!;
    private List<Staff> _staff = default!;
    private InventoryReporter _reporter = default!;

    [TestInitialize]
    public void Setup()
    {
        _animals = new List<Animal>
        {
            new Animal("Лео", "Лев", "Африканський лев", 5),
            new Animal("Тигра", "Тигр", "Бенгальський тигр", 3),
            new Animal("Белла", "Білий ведмідь", "Арктичний ведмідь", 4)
        };

        _enclosures = new List<Enclosure>
        {
            new Enclosure("E1", 250.5, "Хижаки"),
            new Enclosure("E2", 150.0, "Ссавці")
        };
        _enclosures[0].AddAnimal(_animals[0]);
        _enclosures[0].AddAnimal(_animals[1]);
        _enclosures[1].AddAnimal(_animals[2]);

        _feeds = new List<Feed>
        {
            new Feed("Лев", "Мʼясо", 50),
            new Feed("Тигр", "Мʼясо", 40),
            new Feed("Білий ведмідь", "Риба", 30)
        };

        _staff = new List<Staff>
        {
            new Staff("Ольга", "Доглядач"),
            new Staff("Іван", "Ветеринарний лікар")
        };

        _reporter = new InventoryReporter(_animals, _staff, _enclosures, _feeds);
    }

    [TestMethod]
    public void GetReport_ShouldContain_CorrectAnimalCount()
    {
        var report = _reporter.GetReport();
        StringAssert.Contains(report, "Усього тварин: 3");
    }

    [TestMethod]
    public void GetReport_ShouldGroupBySpecies()
    {
        var report = _reporter.GetReport();
        StringAssert.Contains(report, "Лев: 1");
        StringAssert.Contains(report, "Тигр: 1");
        StringAssert.Contains(report, "Білий ведмідь: 1");
    }

    [TestMethod]
    public void GetReport_ShouldListStaffCount()
    {
        var report = _reporter.GetReport();
        StringAssert.Contains(report, "Персоналу: 2");
    }

    [TestMethod]
    public void GetReport_ShouldListFeedQuantities()
    {
        var report = _reporter.GetReport();
        StringAssert.Contains(report, "Лев: 50 кг Мʼясо");
        StringAssert.Contains(report, "Тигр: 40 кг Мʼясо");
    }
}
