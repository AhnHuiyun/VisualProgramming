using System;
namespace Current_exchange
{
    class Program
    {
        public static void Exchange(float Won, out float Dollar, out float Yen)
        {
            Dollar = Won / 1100;
            Yen = Won / 10;
        }
        static void Main(string[] args)
        {
            float Won, Dollar, Yen;
            Console.Write("환산할 돈은 얼마입니까? 원으로 입력해주세요.?");
            Won = float.Parse(Console.ReadLine());
            Exchange(Won, out Dollar, out Yen);
            Console.WriteLine("님께서 입력하신 액수는 미화로는 {0} 달러입니다.", Dollar);
            Console.WriteLine("님께서 입력하신 액수는 일화로는 {0} 엔입니다.", Yen);
        }
    }
}
