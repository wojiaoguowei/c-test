using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            long lRes = cl.Add(23, 40);
            cl.Extra = false;

            return;
        }
    }
}
