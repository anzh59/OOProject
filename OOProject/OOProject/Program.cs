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
            Random random = new Random();
            Vector aVector = new Vector(7) { Printer = new ConsolePrinter() };

            for (int i = 0; i < aVector.ElementsCount; i++)
            {
                aVector[i] = random.Next(25);
            }

            aVector.Print();

            aVector.ChangeMinAndMax();
            aVector.Print();

            Vector bVector = new Vector(7) { Printer = new ConsolePrinter() };

            for (int i = 0; i < bVector.ElementsCount; i++)
            {
                bVector[i] = random.Next(25);
            }

            bVector.Print();


            Vector cVector = (aVector + bVector);
            cVector.Printer = new ConsolePrinter();

            cVector.Print();

            Console.ReadKey();
        }
    }
}
