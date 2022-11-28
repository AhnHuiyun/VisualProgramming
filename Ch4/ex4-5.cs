using System;
class CallByReferenceApp
{
    static void Swap(ref int x, ref int y)
    {
        int temp;
        temp = x; x = y; y = temp;
        Console.WriteLine(" Swap: x = {0}, y = {1}", x, y);
    }
    public static void Main()
    {
        int x = 1, y = 2; // x, y 는 값형
        Console.WriteLine("Before: x = {0}, y = {1}", x, y);
        Swap(ref x, ref y); // x, y가 1, 2로 초기화된 상태
        Console.WriteLine(" After: x = {0}, y = {1}", x, y);
    }
}