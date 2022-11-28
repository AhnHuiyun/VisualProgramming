using System;
using System.IO;
namespace File_IO
{
    class save_read
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate,
            FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++) //20회 저장
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0; //스트림의 위치를 시작으로 설정
            for (int i = 0; i <= 20; i++) //21회 읽음
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}
//출력 파일 test.dot파일은 ~/bin/Debug 폴더에 저장
//UltraEdit 편집기에서 Hex 형태로 읽으면 볼 수 있음(편집-> Hex기능-> Hex편집)