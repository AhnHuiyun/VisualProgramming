using System;
class Color
{
    private string[] color = new string[5];
    public string this[int index]
    {
        get { return color[index]; }
        set { color[index] = value; } // value는 예약어
    }
}
class IndexerApp
{
    public static void Main()
    {
        Color c = new Color();
        c[0] = "WHITE"; c[1] = "RED";
        c[2] = "YELLOW"; c[3] = "BLUE";
        c[4] = "BLACK";
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Color is " + c[i]);
    }
}