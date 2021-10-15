using System;
using System.Diagnostics;

namespace Task2
{
    public class A
    {
        public B[] Arguments;

        public A(B b1, B b2)
        {
            Arguments = new[] { b1, b2 };
        }

        public A(B b1, B b2, B b3)
        {
            Arguments = new[] { b1, b2, b3 };
        }

        public void PropertiesOfArguments()
        {
            Debug.WriteLine($"Свойства аргументов:");
            Debug.Indent();

            foreach (var argument in Arguments)
                argument.PrintProperties();

            Debug.Unindent();
        }
    }
    public class B
    {
        public virtual void PrintProperties()
        {
            Debug.WriteLine($"У класса нет агрументов");
        }
    }
    public class C : B
    {
        public string Name { get; set; } = "";

        public C(string name)
        {
            Name = name;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine("Свойства класса С:");
            Debug.Indent();
            Debug.WriteLine($"{nameof(Name)}: {Name}");
            Debug.Unindent();
        }
    }
    public class D : B
    {
        public DateTime Time { get; }

        public D()
        {
            Time = DateTime.Now;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine($"Свойства класса Д:");
            Debug.Indent();
            Debug.WriteLine($"{nameof(Time)}: {Time}");
            Debug.Unindent();
        }
    }
    public class E : B
    {
        public int DateTime { get; }

        private static int DayOfWeek = 3;

        public E()
        {
            DayOfWeek = ++DayOfWeek;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine($"Свойства класса Е:");
            Debug.Indent();
            Debug.WriteLine($"{nameof(DayOfWeek)}: {DayOfWeek}");
            Debug.Unindent();
        }
    }
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
