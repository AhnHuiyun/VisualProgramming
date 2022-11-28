using System;
namespace indexer_exam_2
{
    class Grade
    { //객체내 정수 배열
        public int[] grades = { 24, 75, 90, 74, 51, 74, 83, 52, 31, 58 };
        public int this[int index]
        {
            get
            {
                return grades[index];
            }
            set
            {
                grades[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Grade grades = new Grade();
            grades[3] = 57; //객체명[index]
            grades[8] = 12;
            for (int i = 0; i < 10; i++) //인덱서를 이용해서 외부에서 Grade 클래스의 객체를 배열 처럼 사용 가능
                Console.WriteLine(grades[i]);
        }
    }
}