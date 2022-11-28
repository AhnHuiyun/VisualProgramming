using System;
class MainApp
{
    public static void Main()
    {
        Calculator calculator = new Calculator();
        int a = 3, b = 7;
        Console.WriteLine("{0}+{1}={2}", a, b, calculator.Plus(a, b));
        Console.WriteLine("{0}-{1}={2}", a, b, calculator.Minus(a, b));
        Console.WriteLine("{0}*{1}={2}", a, b, calculator.Multiply(a, b));
        Console.WriteLine("{0}/{1}={2}", a, b, calculator.Divide(a, b));
    }
}