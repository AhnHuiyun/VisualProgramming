using System;
namespace Polymorphism_2
{
    interface IShape
    {
        void Draw();
    }
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Circle");
        }
        public void CalArea()
        {
            Console.WriteLine("PI * R * R");
        }
    }
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
        public void CalArea()
        {
            Console.WriteLine("W * H");
        }
    }
    public class Line : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Line");
        }
        public void CalArea()
        {
            Console.WriteLine("No Area");
        }
    }