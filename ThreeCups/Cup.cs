using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeCups
{
    public class Cup

    {
        public char _position;
        public bool _containsBall = false;

        public Cup(char position, bool containsBall)
        {
            _position = position;
            _containsBall = containsBall;
        }
    }
}
