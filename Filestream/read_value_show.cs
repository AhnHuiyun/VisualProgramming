using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//"num.dat" 파일을 실행 파일 폴더( ../bin/Debug 폴더)에 둠
//파일 이름에 인용부호 " 붙이기, 파일 형식 : 모든 파일, 인코딩 : UTF-8
namespace Filestream
{
    internal class read_value_show
    {
        static void Main(string[] args)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("num.dat", FileMode.Open);
            }
            catch (IOException)
            {
                Console.WriteLine("Input 파일을 열 수 없습니다.");
                return;
            }
            StreamReader r = new StreamReader(fs);
            string s;
            s = r.ReadLine();
            string[] ks = s.Split(' ');
            int a, b, c;
            a = Int32.Parse(ks[0]);
            b = Int32.Parse(ks[1]);
            c = Add(a, b);
            FileStream os;
            try
            {
                os = new FileStream("result.dat", FileMode.Create);
            }
            catch (IOException)
            {
                Console.WriteLine("Output 파일을 열 수 없습니다.");
                return;
            }
            StreamWriter w = new StreamWriter(os);
            Console.WriteLine("a + b= c : {0} + {1} = {2}", a, b, c);
            w.WriteLine("a + b= c : {0} + {1} = {2}", a, b, c);
            r.Close();
            w.Close();
        }
        static int Add(int x, int y)
        {
            return (x + y);

        }
    }
}
