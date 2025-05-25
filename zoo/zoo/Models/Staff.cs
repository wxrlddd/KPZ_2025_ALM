namespace ZooLab.Models;

public class Staff
{
    public string Name { get; set; }
    public string Role { get; set; }

    public Staff(string name, string role)
    {
        Name = name;
        Role = role;
    }
}
