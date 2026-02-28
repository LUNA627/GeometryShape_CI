using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentException("Высота и длина должны быть положительными");
            }

            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;
        public override double Perimeter() => 2 * (Width + Height);
        public override string ToString() => $"Прямоугольник: Ширина - {Width}; Длина - {Height}";
    }
}
