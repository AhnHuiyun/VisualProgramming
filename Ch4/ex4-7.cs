using System;
class ParameterArrayApp
{
    static void ParameterArray(params object[] obj)
    {
        for (int i = 0; i < obj.Length; i++)
            Console.WriteLine(obj[i]);
    }
    public static void Main()
    {
        ParameterArray(123, "Hello", true, 'A');
    }
}
//지원되는 건 안되 남용은 x