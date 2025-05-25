using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZooLab.Interfaces;
using ZooLab.Models;

namespace ZooLab.Services;

public class InventoryReporter : IReportable
{
    private readonly IEnumerable<Animal> _animals;
    private readonly IEnumerable<Staff> _staff;
    private readonly IEnumerable<Enclosure> _enclosures;
    private readonly IEnumerable<Feed> _feeds;

    public InventoryReporter(
        IEnumerable<Animal> animals,
        IEnumerable<Staff> staff,
        IEnumerable<Enclosure> enclosures,
        IEnumerable<Feed> feeds)
    {
        _animals = animals;
        _staff = staff;
        _enclosures = enclosures;
        _feeds = feeds;
    }

    public string GetReport()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Усього тварин: {_animals.Count()}");
        sb.AppendLine("За видами:");
        foreach (var group in _animals.GroupBy(a => a.Species))
            sb.AppendLine($"  {group.Key}: {group.Count()}");
        sb.AppendLine($"Персоналу: {_staff.Count()}");
        sb.AppendLine($"Вольєрів: {_enclosures.Count()}");
        sb.AppendLine("Запаси корму:");
        foreach (var feed in _feeds)
            sb.AppendLine($"  {feed.AnimalType}: {feed.QuantityKg} кг {feed.FoodType}");
        return sb.ToString();
    }
}
