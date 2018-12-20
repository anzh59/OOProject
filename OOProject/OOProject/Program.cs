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
            Vector aVector = new Vector("A", 5, new ConsolePrinter());
            aVector.FillWithRandomValues(20);
            aVector.Print();

            aVector.ChangeMinAndMax();
            aVector.Print();

            Vector bVector = new Vector("B", 5, new ConsolePrinter());
            bVector.FillWithRandomValues(20);

            bVector.Print();


            Vector cVector = (aVector + bVector);
            cVector.Printer = new ConsolePrinter();

            cVector.Print();

            Console.ReadKey();
        }
    }
}
