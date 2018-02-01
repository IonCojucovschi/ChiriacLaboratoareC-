using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAboratorul_numarul_3
{
    class Program
    {
        static int[,] a, b, rez, t1, p1, gr;
        static int[] c, f;
        static int r1, d1, d2, r, d, r2, n, m, t, i, j, p, l;


        static void Main(string[] args)
        {
            t1 = new int[30, 30];
            int[,] b = new int[4, 4] { { 0,0,0,0},{0,1,2,3 },{0,3,1,2 },{0,2,3,1 } }; 
            int[,] ai = new int[3, 3] { { 0,0,0},{0,1,2 },{0,2,1 } };
            ///{ { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1,2,3,4,5,6 }, { 0, 3,1,2,6,4,5 }, { 0,2,3,1,5,6,4}, { 0,4,5,6,1,2,3}, { 0,6,4,5,3,1,2}, { 0,5,6,4,2,3,1} };
            ///{ { 0, 0, 0, 0 }, { 0, 1, 2, 3 }, { 0, 2, 3, 1 }, { 0, 3, 1, 2 } };
            ////{ { 0,0,0,0,0}, {0, 2, 3, 1, 4 }, {0,4,1,3,2 },{0,3,2,4,1 },{0,1,4,2,3 } };
            int n = 0;
            Console.Write("Dati ordinul matricei a, n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati ordinul matricei b, m=");
            m = Convert.ToInt32(Console.ReadLine());

            ////initializationmatrix(a,n);      ///initiate matrix 
            produs_cartezian(out a, ai, b, n, m);
            n = n * m;
            r = 0; r1 = 0;

            afisare(a, n);
            asociativ(a, n);
            medial(a, n);
            paramedial(a, n);
            bicomutativ(a, n);
            ag_gr(a, n);
            ga_gr(a, n);
            ga_gr1(a, n);
            ad_gr(a, n);
            da_gr(a, n);
            hexagonal(a, n);
            dist_dr(a, n);
            dist_st(a, n);
            unitate_dreapta(a, n, out r);
            unitate_stanga(a, n, out r1);
            unitate(ref r, ref r1);
            ward(a, n);
            ward_invers(a, n);

            Console.ReadKey();




        }
        public static  void initializationmatrix(out int[,] a,int n) {
            ////initializam rarrayul 
            a = new int[15, 15];
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("a[" + i + 1 + "," + j + 1 + "]=");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }


        }


        public static void produs_cartezian(out int[,] masiv,int[,] a,int[,] b,int n,int m)
        {   int k = 1;
            masiv = new int[30, 30];
           int[] c= new int[100];
           int[] f= new int[100];
            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < m + 1; j++)
                {
                    f[k] = j;
                    c[k] = i;
                    t1[i,j] = k;
                    k=k+1;
                }
            for (int i = 1; i < m * n+1; i++)
                for (int j = 1; j < n * m+1; j++)
                {
                    masiv[i, j] = t1[a[c[i], c[j]], b[f[i], f[j]]];
                }


        }


        public static void afisare(int[,] a, int n)
        {

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    Console.Write(" "+a[i, j]);
                }
                Console.WriteLine("//"+i+"//"+j);
            }
            Console.WriteLine();
        }



        public static void asociativ(int[,] masiv, int n)
        {

            int l = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[j, k];
                        d1 = masiv[i, j];
                        if (masiv[i, d] != masiv[d1, k]) l++;
                    }

                }
            }
            if (l == 0) Console.WriteLine("ESTE ASOCIATIV");
            else Console.WriteLine("NU ESTE ASOCIATIV");

        }

        public static void medial(int[,] masiv, int n)
        {
            int l = 0;

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        for (int t = 1; t < n + 1; t++)
                        {

                            d = masiv[i, j];
                            r = masiv[k, t];
                            d1 = masiv[i, k];
                            r1 = masiv[j, t];
                            if (masiv[d, r] != masiv[d1, r1])
                                l++;

                        }
                    }
                }
            }
            if (l == 0) Console.WriteLine("ESTE MEDIAL");
            else Console.WriteLine("NU ESTE MEDIAL");

        }

        public static void paramedial(int[,] masiv, int n)
        {
            int l = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        for (int t = 1; t < n + 1; t++)
                        {

                            d = masiv[i, j];
                            r = masiv[k, t];
                            d1 = masiv[t, j];
                            r1 = masiv[k, i];
                            if (masiv[d, r] != masiv[d1, r1]) l++;

                        }
                    }
                }
            }
            if (l == 0) Console.WriteLine("ESTE PARAMEDIAL");
            else Console.WriteLine("NU ESTE PARAMEDIAL");
        }

        public static void bicomutativ(int[,] masiv, int n)
        {

            int l = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        for (int t = 1; t < n + 1; t++)
                        {

                            d = masiv[i, j];
                            r = masiv[k, t];
                            d1 = masiv[t, k];
                            r1 = masiv[j, i];
                            if (masiv[d, r] != masiv[d1, r1]) l++;

                        }
                    }
                }
            }
            if (l == 0) Console.WriteLine("ESTE BICOMUTATIV");
            else Console.WriteLine("NU ESTE BICOMUTATIV");
        }

        public static void ag_gr(int[,] masiv, int n)
        {

            int l = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[i, j];
                        d1 = masiv[k, j];
                        if (masiv[d, k] != masiv[d1, i]) l++;
                    }
                }
            }
            if (l == 0) Console.WriteLine("ESTE AG GRUPOID");
            else Console.WriteLine("NU ESTE AG GRUPOID");
        }

        public static void ga_gr(int[,] masiv, int n)
        {

            int l = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[i, j];
                        d1 = masiv[j, i];
                        if (masiv[d, k] != masiv[k, d1]) l++;
                    }
                }
            }
            if (l == 0) Console.WriteLine("ESTE GA GRUPOID");
            else Console.WriteLine("NU ESTE GA GRUPOID");
        }


        public static void ga_gr1(int[,] masiv, int n)
        {
            int l = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[i, j];
                        d1 = masiv[k, i];
                        if (masiv[d, k] != masiv[d1, j]) l++;
                    }
                }
            }
            if (l == 0) Console.WriteLine("ESTE GA1 GRUPOID");
            else Console.WriteLine("NU ESTE GA1 GRUpoid");
        }

        public static void ad_gr(int[,] masiv, int n)
        {
            int l = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[j, k];
                        d1 = masiv[j, i];
                        if (masiv[i, d] != masiv[k, d1]) l++;
                    }
                }
            }
            if (l == 0) Console.WriteLine("ESTE AD GRUPOID");
            else Console.WriteLine("NU ESTE AD GRUpoid");
        }


        public static void da_gr(int[,] masiv, int n)
        {
            int l = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[j, k];
                        d1 = masiv[i, j];
                        if (masiv[i, d] != masiv[k, d1]) l++;
                    }
                }
            }
            if (l == 0) Console.WriteLine("ESTE DA GRUPOID");
            else Console.WriteLine("NU ESTE DA GRUpoid");
        }



        public static void hexagonal(int[,] masiv, int n)
        {
            int l = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        for (int t = 1; t < n + 1; t++)
                        {

                            d = masiv[i, j];
                            r = masiv[k, t];
                            d1 = masiv[i, k];
                            r1 = masiv[j, t];
                            r2 = masiv[j, i];
                            if (masiv[i, i] != i || masiv[d, r] != masiv[d1, r1] || masiv[i, r2] != masiv[d, i] && masiv[d, i] != j) l++;

                        }
                    }
                }
            }
            if (l == 0) Console.WriteLine("ESTE HEXAGONAL");
            else Console.WriteLine("NU ESTE HEXAGONAL");
        }


        public static void dist_dr(int[,] masiv, int n)
        {
            int l = 0;

            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < n + 1; j++)
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[i, j];
                        d1 = masiv[i, k];
                        r1 = masiv[j, k];
                        if (masiv[d, k] != masiv[d1, r1]) l++;
                    }

            if (l == 0) Console.WriteLine("ESTE DISTRIBUTIV DE DREAPTA");
            else Console.WriteLine("NU ESTE DISTRIBUTIV DE DREAPTA");

        }

        public static void dist_st(int[,] masiv, int n)
        {
            int l = 0;

            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < n + 1; j++)
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[i, j];
                        d1 = masiv[k, i];
                        r1 = masiv[k, j];
                        if (masiv[k, d] != masiv[d1, r1]) l++;
                    }

            if (l == 0) Console.WriteLine("ESTE DISTRIBUTIV DE STANGA");
            else Console.WriteLine("NU ESTE DISTRIBUTIV DE STANGA");

        }










        public static void unitate_dreapta(int[,] masiv, int n, out int r)
        {
            int l;
            int j = 0; r = 0;
            for (int i = 1; i < n + 1; i++)
            {
                l = 0;
                j++;
                if (masiv[j, i] == i)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        if (masiv[k, j] == k) l++;
                        if (l == n) r = j;
                    }
                }
            }
            if (r != 0) Console.WriteLine("ESTE UNITATE DREAPTA  " + r);
            else Console.WriteLine("NU ESTE UNITATE STANGA");
        }



        public static void unitate_stanga(int[,] masiv, int n, out int r2)
        {
            int l;
            int j = 0; r2 = 0;
            for (int i = 1; i < n + 1; i++)
            {
                l = 0;
                j++;
                if (masiv[i, j] == i)
                {
                    for (int k = 1; k < n + 1; k++)
                    {
                        if (masiv[j, k] == k) l++;
                        if (l == n) r2 = j;
                    }
                }
            }
            if (r2 != 0) Console.WriteLine("ESTE UNITATE STANGA  " + r2);
            else Console.WriteLine("NU ESTE UNITATE STANGA");
        }


        public static void unitate(ref int r, ref int r2)
        {

            if (r1 == r2 && r > 0) Console.WriteLine("Este unitate " + r);
            else Console.WriteLine("NU este unitate");

        }

        public static void ward(int[,] masiv, int n)
        {
            int l = 0;
            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < n + 1; j++)
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[i, j];
                        d1 = masiv[i, k];
                        d2 = masiv[j, k];
                        if (d != masiv[d1, d2]) l += 1;
                    }

            if (l == 0) Console.WriteLine("ESTE WARD");
            else Console.WriteLine("NU ESTE WARD");
        }


        public static void ward_invers(int[,] masiv, int n)
        {
            int l = 0;
            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < n + 1; j++)
                    for (int k = 1; k < n + 1; k++)
                    {
                        d = masiv[i, j];
                        d1 = masiv[k, i];
                        d2 = masiv[k, j];
                        if (d != masiv[d1, d2]) l += 1;
                    }

            if (l == 0) Console.WriteLine("ESTE WARD INVERS");
            else Console.WriteLine("NU ESTE WARD INVERS");
        }



    }
}
