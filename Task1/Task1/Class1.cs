using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Task1
{
    public class Class1
    {
        public virtual void WhatToDebug(params object[] args)
        {
            Debug.WriteLine("Arguments: ");
            Debug.Indent();

            foreach (var argument in args)
                Debug.WriteLine(argument);

            Debug.Unindent();
        }
    }
}
