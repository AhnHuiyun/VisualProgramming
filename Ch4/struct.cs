using System;

public struct Point
{
    public int x;
    public int y;
    //public Point() {} //생성자(오류)
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
class structure 
{
    static void Main(string[] args)
    { 
    Point p = new Point(30, 70);
        Console.WriteLine("I am still at stack"); 
        Console.WriteLine("Point.x={p.x}, Point.y={p.y}");
        Point s;
        s.x = 30;
        s.y = -49;
        Console.WriteLine("I am at stack");
        Console.WriteLine("Point.x={s.x}, Point.y={s.y}");
    }
}

