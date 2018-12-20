using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    class ConsolePrinter : IPrinter
    {
        public void Print(IEnumerable collection)
        {
            Console.WriteLine(Environment.NewLine + "Vector elements:");
            foreach (var el in collection)
            {
                Console.Write(el + " ");
            }
        }
    }
}
