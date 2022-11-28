using System;
class AnotherBlock
{
    public static void Main(string[] args)
    {
        int x = 1;
        {
            // int x; // error ( 블록 밖의 변수와 겹침)
            //메소드 내 지역변수 이름은 블록 밖에 선언된 변수들의 이름과 달라야 함
            int y = 2;
            Console.WriteLine("Block 1: x = " + x + ", y = " + y);
        }
        {
            int y = 3;
            Console.WriteLine("Block 2: x = " + x + ", y = " + y);
        }
    }
}