using System;
using System.Diagnostics;

namespace Task1
{
    public class Class1
    {
        public virtual void WhatToDebug(params object[] args)
        {
            Debug.WriteLine("Arguments: ");
            Debug.Indent();

            foreach(var argument in args)           
                Debug.WriteLine(argument);

            Debug.Unindent();          
        }
    }
    public class Class2: Class1
    {
        public override void WhatToDebug(params object[] args)
        {
            Debug.WriteLine("Arguments: ");
            Debug.Indent();

            foreach (var argument in args)
                Debug.WriteLine($"http://{argument.GetType()}: {argument}");
            Debug.Unindent();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1[] Class = new[]
            {
                new Class1(),
                new Class2()
            };
            foreach (var a in Class)
                a.WhatToDebug("Monday", 36.6d, DateTime.Now, 322);

            Console.ReadLine();
        }     
    }
}
