using System;
using System.IO;
//Temp 폴더에 vs.png 미리 저장
namespace ConsoleApplication1
{
    class read_img
    {
        static void Main(string[] args)
        {
            //using문을 사용했기 때문에 Close() 불필요
            using (FileStream fs = new FileStream(@"C:\Temp\vs.png", FileMode.Open))
            {
                int size = (int)fs.Length; //long 형을 int 형으로
                byte[] buff = new byte[size];
                // 이미지를 10번에 걸쳐 나누어 읽음
                for (int i = 0; i < 10; i++)
                {
                    int n = fs.Read(buff, 0, size / 10);
                    //....
                    Console.WriteLine(n);
                }
            }
        }
    }
}
//실행 결과 7538/10인 753 출력