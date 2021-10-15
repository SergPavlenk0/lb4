using System;
using System.Diagnostics;

namespace Task3
{

    public class MainClass
    {
        public virtual void PrintProperties()
        {
            Debug.WriteLine("Class B has no properties");
        }
    }
    public class SuccessorClass1 : MainClass
    {
        public string Name { get; set; } = "";

        public SuccessorClass1(string name)
        {
            Name = name;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine("Свойства наследовательного класса 1:");
            Debug.Indent();
            Debug.WriteLine($"{nameof(Name)}: {Name}");
            Debug.Unindent();
        }
    }
    public class SuccessorClass2 : MainClass
    {
        public int Age { get; }

        private static int ChildAge = 8;

        public SuccessorClass2()
        {
            Age = ChildAge;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine("Свойства наследовательного класса 2:");
            Debug.Indent();
            Debug.WriteLine($"{nameof(Age)}: {Age}");
            Debug.Unindent();
        }
    }
    public class SuccessorClass3 : MainClass
    {
        public DateTime Time { get; }

        public SuccessorClass3()
        {
            Time = DateTime.Now;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine("Свойства наследовательного класса 3:");
            Debug.Indent();
            Debug.WriteLine($"{nameof(Time)}: {Time}");
            Debug.Unindent();
        }
    }
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
