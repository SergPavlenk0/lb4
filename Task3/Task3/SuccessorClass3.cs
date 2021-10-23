using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Task3
{
    public class SuccessorClass3:MainClass
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
}
