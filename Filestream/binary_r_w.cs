using System;
using System.IO;

namespace Filestream
{
    internal class binary_r_w
    {
        static void Main()
        {
            string dirPath = @"c:/Temp";
            // Create the folder c:\temp if it doesn't exist
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            string fileName = dirPath + "/TestFile.bin";
            // create binary file if it doesn't exist
            //쓰기동작
            if (!File.Exists(fileName))
            {
                // file doesn't exist - create file
                FileStream fs = new FileStream(fileName, FileMode.CreateNew);
                BinaryWriter bw = new BinaryWriter(fs);
                byte[] byteArray = { 0x48, 0x45, 0x4C, 0x4C, 0x4F }; // hello!
                for (int i = 0; i < byteArray.Length; i++)
                {
                    bw.Write(byteArray[i]);
                }
                bw.Close();
                fs.Close();
            }// and read it back
            //읽기 동작
            FileStream fsRead = new FileStream(fileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fsRead);
            for (int i = 0; i < fsRead.Length; i++)
            {
                Console.Write((char)(br.ReadByte()));
            }
            br.Close();
            fsRead.Close();
        }
    }
}
//c:/Temp에 TestFile 저장된 거 확인하기