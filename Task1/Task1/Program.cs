using System;
using System.Diagnostics;

namespace Task1
{
    
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
