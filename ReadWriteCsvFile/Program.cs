using SharedClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteCsvFile
{
    class Program
    {
        private static List<Person> persons = new List<Person>();

        static void Main(string[] args)
        {
            CsvService.WriteToFile(@"d:\files\persons.csv", "Samuel; Wessen; 34; Örebro");
            var persons = CsvService.ReadFromFile(@"d:\files\persons.csv");

            foreach (var person in persons)
            {
                Console.WriteLine($"{ person.FirstName} {person.LastName} is {person.Age} years old and lives in {person.City}");
            }
        }




    }
}
