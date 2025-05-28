using System;

namespace Lab4.Task2.Models
{
    public class Runway
    {
        public Guid Id { get; } = Guid.NewGuid();
        public bool IsBusy { get; private set; }
        public string OccupiedBy { get; private set; }

        public bool IsFree() => !IsBusy;

        public void Occupy(string aircraftName)
        {
            IsBusy = true;
            OccupiedBy = aircraftName;
            Console.WriteLine($"Смуга {Id} зайнята літаком {aircraftName}.");
        }

        public void FreeUp(string aircraftName)
        {
            IsBusy = false;
            Console.WriteLine($"Смуга {Id} звільнена літаком {aircraftName}.");
        }
    }
}
