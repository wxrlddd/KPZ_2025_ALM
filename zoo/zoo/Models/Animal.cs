namespace ZooLab.Models;

public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public string Subspecies { get; set; }
    public int Age { get; set; }

    public Animal(string name, string species, string subspecies, int age)
    {
        Name = name;
        Species = species;
        Subspecies = subspecies;
        Age = age;
    }
}
