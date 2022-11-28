using System;
class PointerApp
{
    unsafe public static void Swap(int* px, int* py)
    {
        int tmp = *px;
        *px = *py;
        *py = tmp;
    }
    public static void Main()
    {
        int x = 1, y = 2;
        Console.WriteLine("Before : x = " + x + ", y = " + y);
        unsafe
        {
            Swap(&x, &y);
        }
        Console.WriteLine(" After : x = " + x + ", y = " + y);
    }
}
//프로젝트->속성->빌드*->안전하지 않은 코드 허용 체크