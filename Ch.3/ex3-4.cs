using System;
class LocalVariableApp
{
    static int x; //필드(멤버 변수)-클래스내 모든 메소드 접근 가능
    public static void Main() //메소드
    {
        //메소드 내 변수(로컬 변수)
        //정적 필드에 값 할당 후 참조
        int x = (LocalVariableApp.x = 2) * 2; //정적 필드 접근 - 클래스명.필드이름
        Console.WriteLine("static x = " + LocalVariableApp.x);
        Console.WriteLine("local x = " + x);
    }
}
