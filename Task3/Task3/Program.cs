using System;
using System.Diagnostics;

namespace Task3
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            var A = new SuccessorClass1("Первый наследовательный класс");
            var B = new SuccessorClass2();
            var C = new SuccessorClass3();

            A.PrintProperties();
            B.PrintProperties();
            C.PrintProperties();
            Console.ReadLine();
        }
    }
}
