using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Task1
{
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
}
