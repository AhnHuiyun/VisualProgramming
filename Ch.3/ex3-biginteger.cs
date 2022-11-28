using System;
using System.Numerics; //참조 추가
namespace Euler_25
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger l1 = 1;
            BigInteger l2 = 1;
            BigInteger current = l1 + l2;
            //최소 1000 자릿수의 길이에 도달 할 때까지 반복한 후, 그 결과 출력함

            while (current.ToString().Length < 1000) 
            {
                l2 = l1;
                l1 = current;
                current = l1 + l2;
            }
            Console.WriteLine(current);
        }
    }
}
//참조 -> 참조 추가 -> System.Numerics 체크