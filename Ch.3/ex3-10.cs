using System;
class CalculatorApp
{
    public static void Main()
    {
        int x, y, r = 0;
        char opr; 
        Console.Write("Enter an operator & two numbers = ");
        opr = (char)Console.Read(); //console에서 한 글자씩 읽음
        x = Console.Read() - '0'; //반환 값이 문자코드에 대응하는 정수 값이므로,
        y = Console.Read() - '0'; //숫자를 얻기 위해 '0'으로 빼 주어야 함
        switch (opr) //char형
        {
            case '+':
                r = x + y;
                Console.WriteLine(x + " + " + y + " = " + r);
                break;
            case '-':
                r = x - y;
                Console.WriteLine(x + " - " + y + " = " + r);
                break;
            case '*':
                r = x * y;
                Console.WriteLine(x + " * " + y + " = " + r);
                break;
            case '/':
                r = x / y;
                Console.WriteLine(x + " / " + y + " = " + r);
                break;
            default:
                Console.WriteLine("Illegal operator ");
                break;
        }
    }
}