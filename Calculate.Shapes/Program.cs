using System;

namespace Calculate.Shapes
{
    public enum ShapeType
    {
        Ellipse,
        Rectangle
    }
    public class Program
    {
        static Shape CreateShape(ShapeType type, double l, double w)
        {
            switch (type)
            {
                case ShapeType.Ellipse:
                    return new Ellipse(l, w);
                //Console.WriteLine("{0:F2}", Shape.area());
                case ShapeType.Rectangle:
                    return new Rectangle(l, w);
                default:
                    return null;
            }
        }

        static void ViewShapeInfo(Shape shape)
        {
            Console.WriteLine(shape);
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0.Exit\n1. Rectangle\n2. Ellipse");
                Console.Write("Select shape: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                    return;

                Console.Write("Please enter the length: ");
                var length = double.Parse(Console.ReadLine());
                Console.Write("Please enter the width: ");
                var width = double.Parse(Console.ReadLine());

                Shape shape;

                switch (choice)
                {
                    case 1:
                        shape = CreateShape(ShapeType.Rectangle, length, width);
                        ViewShapeInfo(shape);
                        break;
                    case 2:
                        shape = CreateShape(ShapeType.Ellipse, length, width);
                        ViewShapeInfo(shape);
                        break;
                    default:
                        Console.WriteLine("Not implemented.");
                        break;
                }
            }
        }
    }
}
