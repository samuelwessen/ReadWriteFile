using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteTextFile
{
    class Program
    {
        static void Main(string[] args)
        {         
            WriteToFile("textfile.txt", "My name is Samuel Wessen and I am 34 years old and live in Örebro.");
            WriteToFile("textfile.txt", "My brothers name are Mikael and Daniel.");
            ReadFromFile("textfile.txt");
        }
        private static void WriteToFile(string filename, string content)
        {
            File.AppendAllText(@$"d:\files\{filename}", content);
        }

        private static void ReadFromFile(string filename)
        {
            var content = File.ReadAllText(@$"d:\files\{filename}");
            Console.WriteLine(content);
        }
    }
}
