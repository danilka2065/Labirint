using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        static string Turn(string w, char p)
        {
            if (w == "w")
            {
                if (p == 'L') w = "s";

                if (p == 'R') w = "n";
            }

            else if (w == "n")
            {
                if (p == 'L') w = "w";

                if (p == 'R') w = "e";
            }

            else if (w == "s")
            {
                if (p == 'L') w = "e";

                if (p == 'R') w = "w";
            }

            else
            {
                if (p == 'L') w = "n";

                if (p == 'R') w = "s";
            }

            return w;
        }

        static string trans(Point a)
        {
            char[] rov = { '0', '0', '0', '0' };
            if (a.North == true)
                rov[3] = '1';
            if (a.East == true)
                rov[0] = '1';
            if (a.West == true)
                rov[1] = '1';
            if (a.South == true)
                rov[2] = '1';

            string c = "s";
            int num = 0;
            int step1 = 0;

            for (int i = 3; i >= 0; i--)
            {
                if (rov[i] == '1')
                {
                    num = num + (int)Math.Pow(2, step1);
                }
                step1++;
            }

            if (num <= 9) c = num.ToString();
            else if (num == 10) c = "a";
            else if (num == 11) c = "b";
            else if (num == 12) c = "c";
            else if (num == 13) c = "d";
            else if (num == 14) c = "e";
            else if (num == 15) c = "f";

            return c;
        }

        static string Rever_step(string step)
        {
            if (step == "w") step = "e";

            else if (step == "e") step = "w";

            else if (step == "s") step = "n";

            else if (step == "n") step = "s";

            return step;
        }

        static void Main(string[] args)
        {
            string pii = "";
            int i_ma = 1;
            string path = "";
            string repath = "";

            string[] line = File.ReadAllLines(@"large-test-in.txt", Encoding.Default);

            int kol_vo_str = Convert.ToInt32(line[0]);
        }
    }
}
