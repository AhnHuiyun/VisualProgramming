using System;
using Shape; // 사용하고자 하는 DLL의 네임스페이스 명시
//오류가 발생-> 프로젝트-> 참조 추가->찾아보기-> …. \Shape\bin\Debug\Shape.dll->추가
public class NamespaceApp
{
    public static void Main()
    {
        Rectangle rect = new Rectangle();
        rect.width = 10;
        rect.height = 20;
        Console.WriteLine("rect : " + rect);
    }
}