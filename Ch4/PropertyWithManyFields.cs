using System;
class PropertyWithManyFieldsApp
{
    private string text = "Dept. of Computer Engineering";
    private bool isModified = false;
    public string Text
    {
        get { return text; }
        set { text = value; isModified = true; } // 2개의 필드와 연관
    }
    public void PrintStatus()
    {
        Console.WriteLine("text is \"" + text + "\", and " +
        (isModified ? "is" : "not") + " modified.");
    }
    public static void Main()
    {
        PropertyWithManyFieldsApp obj = new PropertyWithManyFieldsApp();
        obj.PrintStatus();
        obj.Text = "Programming Language Lab"; // 프로퍼티의 set 동작
        obj.PrintStatus();
    }
}