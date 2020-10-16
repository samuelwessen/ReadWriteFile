using SharedClassLibrary;
using System;

namespace ReadWriteXmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlService.WriteToFile(@"d:\files\books.xml");
            XmlService.ReadFromFile(@"d:\files\books.xml");
        }
    }
}
