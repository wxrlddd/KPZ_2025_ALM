namespace Lab3.Bridge
{
    public class Square : Shape
    {
        private float side;

        public Square(IRenderer renderer, float side)
            : base(renderer)
        {
            this.side = side;
        }

        public override void Draw()
        {
            renderer.RenderSquare(side);
        }

        public override void Resize(float factor)
        {
            side *= factor;
        }
    }
}