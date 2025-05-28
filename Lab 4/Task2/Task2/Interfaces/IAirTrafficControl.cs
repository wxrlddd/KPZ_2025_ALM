using Lab4.Task2.Models;

namespace Lab4.Task2.Interfaces
{
    public interface IAirTrafficControl
    {
        void RequestLanding(Aircraft aircraft);
        void RequestTakeOff(Aircraft aircraft);
    }
}
