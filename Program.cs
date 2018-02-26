using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppFileIO
{
    class Program
    {

        static void Main(string[] args)
        {
            FileStream f = new FileStream("F:\\fileIO\\myfile3.txt", FileMode.OpenOrCreate);
            f.WriteByte(65);
            f.WriteByte(90);
            for (int i = 66; i <= 90; i++)
            {
                f.WriteByte((Byte)i);

            }
            f.Close();
            Console.Read();
        }
    }
}
