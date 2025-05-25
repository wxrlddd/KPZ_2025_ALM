namespace PrototypePattern.Prototypes
{
    public class Virus : VirusPrototype
    {
        public Virus(string name, int age, string type, double weight)
        {
            Name = name; Age = age; Type = type; Weight = weight;
        }

        public override VirusPrototype Clone()
        {
            var copy = new Virus(Name, Age, Type, Weight);
            foreach (var c in Children)
                copy.Children.Add(c.Clone());
            return copy;
        }
    }
}
