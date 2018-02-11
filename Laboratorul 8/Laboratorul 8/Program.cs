using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_8
{
    class Program
    {
        public static string f1, f2;
        public static int[] e, a, b, g, h, r, pr=new int[4];

        static void Main(string[] args)
        {

            e=new int[4] { 0,1, 2, 3 };
            a = new int[4] { 0, 2,3 ,1 };
            b = new int[4] { 0, 3, 1, 2 };
            g = new int[4] { 0, 2, 1, 3 };
            h = new int[4] { 0, 3, 2, 1 };
            r = new int[4] { 0, 1, 3, 2 };




            citire();
            Console.WriteLine(f2);
            f2 += "\n\n\n\n";
            prod(e, e); prod(e, a);prod(e, b);prod(e,g);prod(e, h);prod(e,r);
            f2 += "\n";
            prod(a, e); prod(a, a); prod(a, b); prod(a, g); prod(a, h); prod(a, r);
            f2 += "\n";
            prod(b, e); prod(b, a); prod(b, b); prod(b, g); prod(b, h); prod(b, r);
            f2 += "\n";
            prod(g, e); prod(g, a); prod(g, b); prod(g, g); prod(g, h); prod(g, r);
            f2 += "\n";
            prod(h, e); prod(h, a); prod(h, b); prod(h, g); prod(h, h); prod(h, r);
            f2 += "\n";
            prod(r, e); prod(r, a); prod(r, b); prod(r, g); prod(r, h); prod(r, r);

            Console.WriteLine(f2);


            //write(f2, 'e|'); prod(e, e); prod(e, a); prod(e, b); prod(e, g); prod(e, h); prod(e, r);
            //writeln(f2);
            //write(f2, 'a|'); prod(a, e); prod(a, a); prod(a, b); prod(a, g); prod(a, h); prod(a, r);
            //writeln(f2);
            //write(f2, 'b|'); prod(b, e); prod(b, a); prod(b, b); prod(b, g); prod(b, h); prod(b, r);
            //writeln(f2);
            //write(f2, 'g|'); prod(g, e); prod(g, a); prod(g, b); prod(g, g); prod(g, h); prod(g, r);
            //writeln(f2);
            //write(f2, 'h|'); prod(h, e); prod(h, a); prod(h, b); prod(h, g); prod(h, h); prod(h, r);
            //writeln(f2);
            //write(f2, 'r|'); prod(r, e); prod(r, a); prod(r, b); prod(r, g); prod(r, h); prod(r, r);

            Console.ReadLine();
        }

        public static void prod(int[] x,int[] y)
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


        public static void citire()
        {
            f2 +="\n e=";
            for (int i = 1; i < 4; i++)
            {
                f2 += e[i];
            }

            f2 += "\n a=";
            for (int i = 1; i < 4; i++)
            {
                f2 += a[i];
            }

            f2 += "\n b=";
            for (int i = 1; i < 4; i++)
            {
                f2 += b[i];
            }


            f2 += "\n g=";
            for (int i = 1; i < 4; i++)
            {
                f2 += g[i];
            }

            f2 += "\n h=";
            for (int i = 1; i < 4; i++)
            {
                f2 += h[i];
            }

            f2 += "\n r=";
            for (int i = 1; i < 4; i++)
            {
                f2 += r[i];
            }
            f2 += "\n";

        }



    }
}




