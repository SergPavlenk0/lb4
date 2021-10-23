using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Task3
{
    public class SuccessorClass2:MainClass
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
}
