using SharedClassLibrary;
using System;

namespace ReadWriteJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //JsonService.WriteToFile(@"d:\files\persons.json", new Person("Samuel", "Wessen", 34, "Örebro"));
            //JsonService.ReadFromFile(@"d:\files\persons.json");
            JsonService.WriteToFileCorrect(@"d:\files\persons.json", new Person("Samuel", "Wessen", 34, "Örebro"));
        }
    }
}
