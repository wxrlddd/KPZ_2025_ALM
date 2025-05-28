using System;
using System.Text;

namespace Lab3.Bridge
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            IRenderer vector = new VectorRenderer();
            Shape circle = new Circle(vector, 5);
            circle.Draw();                 
            circle.Resize(2);
            circle.Draw();                 

            IRenderer raster = new RasterRenderer();
            Shape square = new Square(raster, 3);
            square.Draw();                  
            square.Resize(3);
            square.Draw();                  
        }
    }
}