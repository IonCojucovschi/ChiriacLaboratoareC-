using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_8
{
    class Program
    {
        public string f1, f2;
        public int[] e, a, b, g, h, r, pr;

        static void Main(string[] args)
        {
        }

        public void prod(int[] x,int[] y)
        {
            int p1, p2, p3, p4, p5, p6;

            for (int i=1;i<3;i++)
            {
                pr[i]= x[y[i]];
            }

            p1 = 1;
            for (int i = 1; i < 3; i++)
            {
                if (pr[i] == e[i]) { p1 = p1; } else { p1 = 0; }
            }
            if (p1 == 1) { f2 += "e"; }

            p2 = 1;
            for (int i = 1; i < 3; i++)
            {
                if (pr[i] == a[i]) { } else { p2 = 0; }
            }
            if (p2 == 1) { f2 += "a"; }

            p3 = 1;
            for (int i = 1; i < 3; i++)
            {
                if (pr[i] == b[i]) { } else { p3 = 0; }
            }
            if (p3 == 1) { f2 += "b"; }

            p4 = 1;
            for (int i = 1; i < 3; i++)
            {
                if (pr[i] == g[i]) { } else { p4 = 0; }
            }
            if (p4 == 1) { f2 += "g"; }

            p5 = 1;
            for (int i = 1; i < 3; i++)
            {
                if (pr[i] == h[i]) { } else { p5 = 0; }
            }
            if (p5 == 1) { f2 += "h"; }

            p6 = 1;
            for (int i = 1; i < 3; i++)
            {
                if (pr[i] == r[i]) { } else { p6 = 0; }
            }
            if (p6 == 1) { f2 += "r"; }
        }


        public void citire()
        {
            f2 +="\n e=";
            for (int i = 1; i < 3; i++)
            {
                f2 += e[i];
            }

            f2 += "\n a=";
            for (int i = 1; i < 3; i++)
            {
                f2 += a[i];
            }

            f2 += "\n b=";
            for (int i = 1; i < 3; i++)
            {
                f2 += b[i];
            }


            f2 += "\n g=";
            for (int i = 1; i < 3; i++)
            {
                f2 += g[i];
            }

            f2 += "\n h=";
            for (int i = 1; i < 3; i++)
            {
                f2 += h[i];
            }

            f2 += "\n r=";
            for (int i = 1; i < 3; i++)
            {
                f2 += r[i];
            }
            f2 += "\n";

        }



    }
}



