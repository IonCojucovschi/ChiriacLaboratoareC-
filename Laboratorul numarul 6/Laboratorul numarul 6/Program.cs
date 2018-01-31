using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_numarul_6
{
    class Program
    {
        static int[,] a, opus, t1, p1, gr,m,m1,m2,m3;
        static int[] b, c, f,alfa,beta,gama;
        static int r1, d1, d2, r, d, r2, n, t, i, j, p, l;


        static void Main(string[] args)
        {
            t1 = new int[30, 30];

            m = new int[5, 5] { { 0, 0, 0, 0,0 }, { 0,4,1,2,3 }, { 0, 3,4,1,2}, { 0,2,3,4,1},{ 0, 1,2,3,4 } };
            int n = 0;
            Console.Write("Dati ordinul matricei a, n=");
            n = Convert.ToInt32(Console.ReadLine());

            afisare(m, n);
            ////initializationmatrix(a,n);      ///initiate matrix 
            alfa = new int[]{0, 2, 3, 4, 1 };
            beta = new int[] {0, 4, 3, 2, 1 };
            gama = new int[] { 0,2,1,4,3};

            iteratiaAlfa(ref m,out m1,ref alfa,n);
            iteratiaBeta(ref m1, out m2, ref beta, n);
            iteratiaGama(ref m2, out m3, ref gama, n);

            afisare(m, n);
            b = new int[100];
            c = new int[100];
            E(m, n);

            afisare(m, n);
            asociativ(m, n);
            medial(m, n);
            paramedial(m, n);
            bicomutativ(m, n);
            ag_gr(m, n);
            ga_gr(m, n);
            ga_gr1(m, n);
            ad_gr(m, n);
            da_gr(m, n);
            hexagonal(m, n);
            dist_dr(m, n);
            dist_st(m, n);

            r = 0; r1 = 0;

            unitate_dreapta(m, n, out r);
            unitate_stanga(m, n, out r1);
            unitate(ref r, ref r1);
            ward(m, n);
            ward_invers(m, n);

            Console.ReadKey();
            ////////ei deam si proprietatile la fiecare 



        }
        public static void initializationmatrix(out int[,] a, int n)
        {
            ////initializam rarrayul 
            a = new int[15, 15];
            for (int i = 1; i < n + 1; i++)
            {

                for (int j = 1; j < n + 1; j++)
                {
                    Console.WriteLine("a[" + i + "," + j + "]=");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }


        }

        public static void iteratiaAlfa(ref int[,] a, out int[,] b, ref int[] substitutia, int n)////numele iteratiei, array a , array b , dimensiunea n
        {
            b = new int[15, 15];
            int t = 0;
            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < n + 1; j++)
                {
                    t = substitutia[i];
                    b[i, j] = a[t, j];
                }
            Console.WriteLine("ITERATIA ALFA");
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    Console.Write(b[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        public static void iteratiaBeta(ref int[,] a, out int[,] b, ref int[] substitutia, int n)////numele iteratiei, array a , array b , dimensiunea n
        {
            b = new int[15, 15];
            int t = 0;
            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < n + 1; j++)
                {
                    t = substitutia[j];
                    b[i, j] = a[i,t];
                }
            Console.WriteLine("ITERATIA BETA");
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void iteratiaGama(ref int[,] a, out int[,] b, ref int[] substitutia, int n)////numele iteratiei, array a(valori) , array b(variabila) , dimensiunea n
        {
            int t = 0;
            b = new int[15, 15];
            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < n + 1; j++)
                {
                    t = a[i, j]; 
                    b[i, j] = substitutia[t];
                }
            Console.WriteLine("ITERATIA GAMA ");
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }



        public static void E(int[,] a, int n)
        {
            int j = 0;
            for (int i = 1; i < n + 1; i++)
            {
                if (a[i, i] == i && nn(a,i, n) != 0 && mm(a,i, n) != 0) { Console.WriteLine("=E(" + nn(a,i, n) + "," + mm(a,i, n) + ");"); j++; }
            }
            if (j == 0) Console.WriteLine("NU sunt");
        }

        public static int mm(int[,] a,int g, int n)
        {
            int ii, jj, k, x, q;

            for (jj = 1; jj < n + 1; jj++)
            {
                k = 0;
                x = jj;

                do
                {
                    x = a[x, g];
                    k++;
                } while (x != jj && k < n + 1);

                if (k > n + 1) b[jj] = 0;
                else b[jj] = k;
            }

            q = b[2];
            for (jj = 2; jj < n + 1; jj++)
            {
                if (b[jj] > q)
                {
                    q = b[jj];
                    break;
                }

            }
            return q;
        }

        public static int nn(int[,]a,int gg, int n)
        {

            int ii, jj, k, x, q;
            for (jj = 1; jj < n + 1; jj++)
            {
                k = 0;
                x = jj;

                do
                {
                    x = a[gg, x];
                    k++;
                } while (x != jj && k < n + 2);

                if (k > n + 1) c[jj] = 0;
                else c[jj] = k;


            }
            q = c[2];
            for (jj = 2; jj < n + 1; jj++)
            {
                if (c[jj] > q) { q = c[jj]; break; }
            }
            return q;
        }

      


        public static void produs_cartezian(out int[,] masiv, int[,] a, int[,] b, int n, int m)
        {
            int k = 1;
            masiv = new int[30, 30];
            int[] c = new int[100];
            int[] f = new int[100];
            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < m + 1; j++)
                {
                    f[k] = j;
                    c[k] = i;
                    t1[i, j] = k;
                    k = k + 1;
                }
            for (int i = 1; i < m * n; i++)
                for (int j = 1; j < n * m; j++)
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
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
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

