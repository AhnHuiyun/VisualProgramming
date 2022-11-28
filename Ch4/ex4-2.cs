using System;
public class StaticVsInstanceApp
{
    int instanceVariable; // private : default
    static int staticVariable;
    public static void Main()
    {
        StaticVsInstanceApp obj = new StaticVsInstanceApp();
        obj.instanceVariable = 10; // ok
                                   //StaticVsInstanceApp.instanceVariable = 10; // error
        StaticVsInstanceApp.staticVariable = 20; // ok
                                                 //obj.staticVariable = 20; // error
        Console.WriteLine("instance variable={0}, static variable={1}",
        obj.instanceVariable, StaticVsInstanceApp.staticVariable);
    }
}
