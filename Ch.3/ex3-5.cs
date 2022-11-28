using System;
class IfStApp
{
    public static void Main()
    {
        int n;
        Console.Write("Enter a number = ");
        n = Console.Read() - '0';
        if (n % 2 == 0) 
            Console.WriteLine(n + " is an even number.");
        if (n % 2 != 0)
            Console.WriteLine(n + " is an odd number.");
    }
}
//2가지 경우만 존재하는데 2개의 if문 사용은 비효율적
//if ~else문으로 바꾸어 주어야함
