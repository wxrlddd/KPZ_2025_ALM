using Lab4.Task2.Interfaces;

namespace Lab4.Task2.Models
{
    public class Aircraft
    {
        public string Name { get; }
        private readonly IAirTrafficControl controlTower;

        public Aircraft(string name, IAirTrafficControl tower)
        {
            Name = name;
            controlTower = tower;
        }

        public void Land() => controlTower.RequestLanding(this);
        public void TakeOff() => controlTower.RequestTakeOff(this);
    }
}
