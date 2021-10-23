using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Task2
{
    public class C:B
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
}
