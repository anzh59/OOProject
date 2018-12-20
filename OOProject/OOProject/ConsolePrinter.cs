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
<<<<<<< HEAD
        public void Print(IEnumerable collection)
        {
            Console.WriteLine(Environment.NewLine + "Vector elements:");
            foreach (var el in collection)
            {
                Console.Write(el + " ");
=======
        public void PrintHeader(string name)
        {
            Console.WriteLine($"Vector {name} elements:");
        }

        public void Print(IEnumerable collection)
        {
            foreach (var el in collection)
            {
                Console.WriteLine(el);
>>>>>>> parent of dbc8a78... Merge branch 'RefactoringBranch'
            }
        }
    }
}
