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
        private Random _random = new Random();

        public Vector(int count)
        {
            _elements = new int[count];
        }

        public void FillWithRandomValues()
        {
            for (int i = 0; i < _elements.Length; i++)
            {
                _elements[i] = _random.Next(20);
            }
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

        public void Print()
        {
            Console.WriteLine("Vector elements:");
            foreach (var el in _elements)
            {
                Console.WriteLine(el);
            }
        }
    }
}
