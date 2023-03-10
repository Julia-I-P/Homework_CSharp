using System;
using System.Data;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Привет!");
            Console.WriteLine("Ваше имя?");
            name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");

        }
    }
       
}