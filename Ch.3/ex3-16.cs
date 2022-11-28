using System;
class BreakStApp
{ // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
    public static void Main()
    {
        int n, i;
        double h = 0.0;
        Console.Write("Enter a number = ");
        n = Console.Read() - '0';
        i = 1;
        while (true)
        {
            h = h + 1 / (double)i;
            if (++i > n) break; //while문 밖으로
        }
        Console.WriteLine(" n = " + n + ", h = " + h);
    }
}