using System;
using Lab4.Task2.Models;
using Lab4.Task2.Services;

namespace Lab4.Task2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

           
            var runway1 = new Runway();
            var runway2 = new Runway();

            
            var controlTower = new AirTrafficControl(
                new[] { runway1, runway2 }
            );

          
            var boeing = new Aircraft("Boeing-747", controlTower);
            var airbus = new Aircraft("Airbus-A320", controlTower);

           
            boeing.Land();
            airbus.Land();

            boeing.TakeOff();
            airbus.TakeOff();
        }
    }
}
