using System;
using System.Diagnostics;

namespace Task2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            A example = new A( new C($"Третий класс"), new D(), new E());

            example.PropertiesOfArguments();
            Console.ReadLine();
        }
    }
}
