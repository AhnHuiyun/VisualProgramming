using System;
namespace CSharp_Auto_Property
{
    class NameCard
    {
        public string Name
        {
            get; set;
        }
        public string PhoneNumber
        {
            get; set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameCard nc = new NameCard();
            nc.Name = "홍길동";
            nc.PhoneNumber = "010-1111-0000";
            Console.WriteLine("Name={0}, Phone_Number={1}", nc.Name, nc.PhoneNumber);
        }
    }
}
