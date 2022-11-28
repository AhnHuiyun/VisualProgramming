using System;
using System.IO;
// Alpha.txt 파일을 실행 파일 폴더( ../bin/Debug 폴더)에 둠
//파일 형식 모든 파일로 변경
//인코딩 : UTF-8 형식
namespace Filestream
{
    internal class streamreader
    {
        static void Main()
        {
            FileStream fs;
            try
            {
                fs = new FileStream("Alpha.txt", FileMode.Open);
            }
            catch (IOException) //변수명 생략(e 미사용)
            {
                Console.WriteLine("파일을 열 수 없습니다.");
                return;
            }
            StreamReader r = new StreamReader(fs); //인자 : 파일 스트림 객체
            string s;
            int i = 1;
            while ((s = r.ReadLine()) != null) //종료까지 줄 단위로 읽음
            {
                Console.WriteLine(i + ":" + s);
                i++;
            }
            r.Close();
        }
    }
}
