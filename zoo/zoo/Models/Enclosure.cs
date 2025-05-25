using System.Collections.Generic;

namespace ZooLab.Models;

public class Enclosure
{
    public string Identifier { get; set; }
    public double SizeSqMeters { get; set; }
    public string Type { get; set; }
    private readonly List<Animal> _animals = new();

    public Enclosure(string id, double sizeSqMeters, string type)
    {
        Identifier = id;
        SizeSqMeters = sizeSqMeters;
        Type = type;
    }

    public void AddAnimal(Animal animal) => _animals.Add(animal);
    public IReadOnlyList<Animal> Animals => _animals;
}
