using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string path = "TestFileStream.txt";
            string data = "Hello,Word!";
            byte[] byteData = new byte[100];
            if (File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();                 
                FileStream fileWrite = File.OpenWrite(path);      
                fileWrite.Write(Encoding.Default.GetBytes(data), 0, 11);
                fileWrite.Close();
                FileStream fileRead = File.OpenRead(path);
                fileRead.Read(byteData,0,100);
                fileRead.Close();
                Console.WriteLine(System.Text.Encoding.Default.GetString(byteData));
            }
            
        }
    }
}
