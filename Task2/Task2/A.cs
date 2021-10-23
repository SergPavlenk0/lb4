using System;
using System.Collections.Generic;
using System.Text;
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
}
