using System;

namespace Lab3.Bridge
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Растровий рендерер: малюємо пікселі кола радіусом {radius}");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"Растровий рендерер: малюємо пікселі квадрата зі стороною {side}");
        }
    }
}