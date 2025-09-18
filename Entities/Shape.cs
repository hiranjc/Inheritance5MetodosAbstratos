using Inheritance5MetodosAbstratos.Entities.Enums;

namespace Inheritance5MetodosAbstratos.Entities
{
    internal abstract class Shape
    {
        private Enums.Color color;

        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}