using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Program
    {
        class Point
        {
            bool north = false;
            bool west = false;
            bool south = false;
            bool east = false;
            public int x, y;

            public Point(int a, int b)
            {
                x = a;
                y = b;
            }

            public bool North
            {
                get { return north; }
                set { north = value; }
            }

            public bool South
            {
                get { return south; }
                set { south = value; }
            }

            public bool West
            {
                get { return west; }
                set { west = value; }
            }

            public bool East
            {
                get { return east; }
                set { east = value; }
            }

        }

        static void Main(string[] args)
        {

        }
    }
}
