using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeCups
{
    public class CupFactory
    {
        private readonly string[] _coordinates; // [ "AB", "CA", "AB" ]
        private readonly Cup[] _cups; // [ A, B, C ]

        public CupFactory(string[] coordinates, params Cup[] cups)
        {
            _cups = cups;
            _coordinates = coordinates;
        }

        public void EnumerateSwaps()
        {
            foreach(var coordinate in _coordinates)
            {
                if (coordinate == "AB" || coordinate == "BA") Swap(0, 1);
                if (coordinate == "AC" || coordinate == "CA") Swap(0, 2);
                if (coordinate == "BC" || coordinate == "CB") Swap(1, 2);
            }
            FindBall();
        }

        private void Swap(int i, int j)
        {
            if (!_cups[i]._containsBall && !_cups[j]._containsBall) return;
            if (!_cups[i]._containsBall)
            {
                _cups[j]._containsBall = false;
                _cups[i]._containsBall = true;
            }
            else
            {
                _cups[j]._containsBall = true;
                _cups[i]._containsBall = false;
            }
        }

        private void FindBall() //public Cup FindBall() => _cups.First(C => C._containsBall); <- better performance
        {
            foreach(var cup in _cups)
            {
                if (cup._containsBall) Console.Write(cup._position);
            }
        }
    }
}
