using System;
delegate void MultiCastDelegate();
class Schedule
{
    public void Now()
    {
        Console.WriteLine("Time : " + DateTime.Now.ToString());
    }
    public static void Today()
    {
        Console.WriteLine("Date : " + DateTime.Today.ToString());
    }
}
class MultiCastApp
{
    public static void Main()
    {
        Schedule obj = new Schedule(); // delegate대상이 되는 메소드를 포함하는 객체 생성
        MultiCastDelegate mcd = new MultiCastDelegate(obj.Now); // delegate 객체(mcd) 생성
        mcd += new MultiCastDelegate(Schedule.Today); // delegate 객체 생성 (+=: multicast)
        mcd(); // delegate 객체 호출 (2개의 메소드 수행)
    }
}