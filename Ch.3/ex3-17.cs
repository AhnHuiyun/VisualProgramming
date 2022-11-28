using System;
class ContinueStApp
{
    public static void Main()
    {
        int n, s, i;
        Console.Write("Enter a number = ");
        for (; ; ) //무한 루프
        {
            n = Console.Read() - '0';
            if (n == 0) break; // 0 입력 시 종료(break 조건)
            else if (n < 0) continue; // 음의 수는 무시
            for (s = 0, i = 1; i <= n; ++i)
                s += i;
            Console.WriteLine("n = " + n + ", sum = " + s);
        }
        Console.WriteLine("End of Main");
    }
}
