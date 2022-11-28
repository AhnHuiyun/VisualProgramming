using System;
namespace Polymorphism_class_1
{
    class Shape
    {
        virtual public void Draw()
        {
        }
    }
    class Circle : Shape
    {
        override public void Draw()
        {
            Console.WriteLine("I am Circle");
        }
    }
    class Rectangle : Shape
    {
        override public void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
    }
    class Triangle : Shape
    {
        override public void Draw()
        {
            Console.WriteLine("I am Triangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Paint(new Circle());
            Paint(new Rectangle());
            Paint(new Triangle());
        }
        static void Paint(Shape shape)
        {
            shape.Draw();
        }
    }
}
