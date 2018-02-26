using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppFileIO
{
    class fileStreamReader
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("F:\\fileIO\\myfile3.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.WriteLine((char)i);
            }
            Console.Read();
            f.Close();   
                
              
        }
    }
}
