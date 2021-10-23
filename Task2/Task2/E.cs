using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Task2
{
    public class E:B
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
}
