using System;
public delegate void MyDelegate(string msg);
class Program
{
    public static void Main()
    {
        MyDelegate del = ClassA.MethodA; // MyDelegate del = new MyDelegate(ClassA.MethodA);
        InvokeDelegate(del);
        del = ClassB.MethodB; // MyDelegate del = new MyDelegate(ClassB.MethodB);
        InvokeDelegate(del);
        del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        InvokeDelegate(del);
    }
    public static void InvokeDelegate(MyDelegate del)
    {
        del("Hello World");
    }
}
class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }
}
class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }
}
