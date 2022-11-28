using System;
class WhileStApp
{ // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
    public static void Main()
    {
        int i, n;
        double h = 0.0; //double 형
        Console.Write("Enter a number = ");
        n = Console.Read() - '0';
        i = 1;
        while (i <= n)
        {
            h = h + 1 / (double)i;
            i++; //조건 변경 문장(없을 경두, 무한 반복)
        }
        Console.WriteLine("n = {0}, h = {1}", n, h);
    }
}
