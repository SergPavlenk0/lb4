using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Task3
{
    public class SuccessorClass1:MainClass
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
}
