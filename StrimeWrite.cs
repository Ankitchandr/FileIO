using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppFileIO
{
    class StrimeWrite
    {
        static void Main(string[] args)
        {
           // FileStream f = new FileStream("F:\\fileIO\\myfile3",FileMode.OpenOrCreate);
            FileStream f = new FileStream("F:\\fileIO\\streamWriter.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("My name is Ankit Chandra");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
            Console.Read();
        }

    }
}
