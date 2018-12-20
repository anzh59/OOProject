using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    class Vector
    {
        private int[] _elements;  
        private IPrinter _printer;

        public Vector(int count)
        {
            _elements = new int[count];
        }

        public int ElementsCount => _elements.Length;

        public IPrinter Printer
        {
            get => _printer;
            set => _printer = value;
        }

        public int this[int index]
        {
            get => _elements[index];
            set => _elements[index] = value;
        }

        public void ChangeMinAndMax()
        {
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < _elements.Length; i++)
            {
                if (_elements[i] < _elements[minIndex])
                    minIndex = i;

                if (_elements[i] > _elements[maxIndex])
                    maxIndex = i;
            }

            int tmpValue = _elements[minIndex];
            _elements[minIndex] = _elements[maxIndex];
            _elements[maxIndex] = tmpValue;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            if (a.ElementsCount != b.ElementsCount)
                Console.WriteLine("Cannot perform the operation: vector's length is different");

            Vector c = new Vector(a.ElementsCount);

            for (int i = 0; i < a.ElementsCount; i++)
            {
                c[i] = a[i] + b[i];
            }

            return c;
        }

        public void Print()
        {
            _printer.Print(_elements);
        }
    }
}
