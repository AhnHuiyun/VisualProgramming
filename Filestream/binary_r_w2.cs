using System;
using System.IO;

namespace Filestream
{
    internal class binary_r_w2
    {
        static void Main(string[] args)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));
            bw.Write(int.MaxValue); //0111111.......1
            bw.Write("Good Morning");
            bw.Write(uint.MaxValue); //1111111.......1
            bw.Write("안녕하세요");
            bw.Write(double.MaxValue);
            bw.Close();
            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
            Console.WriteLine("File Size: {0} bytes", br.BaseStream.Length);
            Console.WriteLine("{0}", br.ReadInt32());
            Console.WriteLine("{0}", br.ReadString());
            Console.WriteLine("{0}", br.ReadUInt32());
            Console.WriteLine("{0}", br.ReadString());
            Console.WriteLine("{0}", br.ReadDouble());
            br.Close();
        }
    }
}
// UltraEdit에서 “a.dat” 파일을 Hex 형식 표현 (편집 -> HEX 기능 -> HEX 편집)
