using GeometryShape;

namespace GeometryShapeTests
{
    public class ShapeTests
    {
        // Создание фигуры "Прямоугольник" - корректный
        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(3, 6, 18)]
        public void Test1(double width, double height, double result)
        {
            var shapeRectangle = new Rectangle(width, height);
            Assert.Equal(result, shapeRectangle.Area(), 2);
        }

        // Создание фигуры "Прямоугольник" - исключение (первое число отрицательное)
        [Theory]
        [InlineData(-2, 2)]
        public void Test2(double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
        }

        // Создание фигуры "Прямоугольник" - исключение (второе число отрицательное)
        [Theory]
        [InlineData(2, -2)]
        public void Test7(double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
        }


        // Создание фигуры "Триугольник" - корректный 
        [Theory]
        [InlineData(3, 4, 5, 12)]
        [InlineData(15, 3, 17, 35)]
        [InlineData(8, 6, 7, 21)]
        [InlineData(3.5, 2.3, 4.1, 9.9)]
        public void Test3(double sideA, double sideB, double sideC, double result)
        {
            var shapeTriangle = new Triangle(sideA, sideB, sideC);
            Assert.Equal(result, shapeTriangle.Perimeter(), 2);
        }

        // Создание фигуры "Триугольник" - исключение (первое число отрицательное)
        [Theory]
        [InlineData(-3, 4, 5)]
        public void Test4(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }


        // Создание фигуры "Триугольник" - исключение (второе число отрицательное)
        [Theory]
        [InlineData(3, -4, 5)]
        public void Test5(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }


        // Создание фигуры "Триугольник" - исключение (третье число отрицательное)
        [Theory]
        [InlineData(3, 4, -5)]
        public void Test6(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        // Создание фигуры "Триугольник" - исключение (непрвильный ввод параметров: sideB + sideC < sideA)
        [Theory]
        [InlineData(13, 4, 5)]
        public void Test9(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }


        // Создание фигуры "Триугольник" - исключение (непрвильный ввод параметров: sideA + sideC < sideB)
        [Theory]
        [InlineData(3, 14, 5)]
        public void Test10(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }


        // Создание фигуры "Триугольник" - исключение (непрвильный ввод параметров: sideA + sideB < sideC)
        [Theory]
        [InlineData(3, 4, 15)]
        public void Test11(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }


        // Расчет площади "Прямоугольника"
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 2, 6)]
        [InlineData(3.3, 2.3, 7.59)]
        public void Test12(double width, double height, double result)
        {
            var shapeRectangle = new Rectangle(width, height);
            Assert.Equal(result, shapeRectangle.Area(), 2);
        }


        // Расчет периметра "Прямоугольника"
        [Theory]
        [InlineData(1, 1, 4)]
        [InlineData(8, 2, 20)]
        [InlineData(3.5, 2.5, 12.0)]
        public void Test13(double width, double height, double result)
        {
            var shapeRectangle = new Rectangle(width, height);
            Assert.Equal(result, shapeRectangle.Perimeter(), 2);
        }
    }
}