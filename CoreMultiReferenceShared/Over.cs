using System;
using System.Collections.Generic;
using System.Text;

namespace CoreMultiReferenceShared
{
    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Square : Shape
    {
        int side;

        public Square(int n) => side = n;

        public override int GetArea() => side * side;
    }
}
