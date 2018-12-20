using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector aVector = new Vector(5, new ConsolePrinter());
            aVector.FillWithRandomValues();
            aVector.Print();

            aVector.ChangeMinAndMax();
            aVector.Print();

            Console.ReadKey();
        }
    }
}
