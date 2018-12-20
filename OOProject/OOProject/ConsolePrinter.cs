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
        public void PrintHeader(string name)
        {
            Console.WriteLine($"Vector {name} elements:");
        }

        public void Print(IEnumerable collection)
        {
            foreach (var el in collection)
            {
                Console.WriteLine(el);
            }
        }
    }
}
