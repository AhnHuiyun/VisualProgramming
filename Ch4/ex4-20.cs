using System;
delegate void DelegateOne(); // delegate with no params
delegate void DelegateTwo(int i); // delegate with 1 param
class DelegateClass
{
    public void MethodA()
    {
        Console.WriteLine("In the DelegateClass.MethodA ...");
    }
    public void MethodB(int i)
    {
        Console.WriteLine("DelegateClass.MethodB, i = " + i);
    }
}
class DelegateCallApp
{
    public static void Main()
    {
        DelegateClass obj = new DelegateClass(); // delegate대상이 되는 메소드를 포함하는 객체 생성
        DelegateOne d1 = new DelegateOne(obj.MethodA); // delegate 객체(d1) 생성
        DelegateTwo d2 = new DelegateTwo(obj.MethodB); // delegate 객체(d2) 생성
        d1(); // invoke MethodA() in DelegateClass // delegate 객체 호출 : 메소드 대리인
        d2(10); // invoke MethodB(10) in DelegateClass // delegate 객체 호출
    }
}