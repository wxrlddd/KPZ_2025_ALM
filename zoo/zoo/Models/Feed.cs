namespace ZooLab.Models;

public class Feed
{
    public string AnimalType { get; set; }
    public string FoodType { get; set; }
    public double QuantityKg { get; set; }

    public Feed(string animalType, string foodType, double quantityKg)
    {
        AnimalType = animalType;
        FoodType = foodType;
        QuantityKg = quantityKg;
    }
}
