using System;

namespace Lab3.Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Векторний рендерер: малюємо коло радіусом {radius}");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"Векторний рендерер: малюємо квадрат зі стороною {side}");
        }
    }
}