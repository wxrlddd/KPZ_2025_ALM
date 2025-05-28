using System;
using System.Collections.Generic;
using System.Linq;
using Lab4.Task2.Interfaces;
using Lab4.Task2.Models;

namespace Lab4.Task2.Services
{
    public class AirTrafficControl : IAirTrafficControl
    {
        private readonly List<Runway> runways;

        public AirTrafficControl(IEnumerable<Runway> rwys)
        {
            runways = new List<Runway>(rwys);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            var free = runways.FirstOrDefault(r => r.IsFree());
            if (free != null)
            {
                Console.WriteLine($"Літак {aircraft.Name} заходить на посадку...");
                free.Occupy(aircraft.Name);
            }
            else
            {
                Console.WriteLine($"Немає вільних смуг для посадки {aircraft.Name}.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            var occupied = runways.FirstOrDefault(r => !r.IsFree());
            if (occupied != null)
            {
                Console.WriteLine($"Літак {aircraft.Name} злітає...");
                occupied.FreeUp(aircraft.Name);
            }
            else
            {
                Console.WriteLine($"Немає зайнятих смуг для зльоту {aircraft.Name}.");
            }
        }
    }
}
