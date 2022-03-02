using System;
using ProjectFirst.Models;

namespace ToDoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(3, "Esam", "Alkureishi");
            person.FirstName = null;
            Console.WriteLine(" " + person.FirstName);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
