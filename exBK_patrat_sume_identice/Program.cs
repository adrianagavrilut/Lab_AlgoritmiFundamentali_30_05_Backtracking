using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exBK_patrat_sume_identice
{
    /// <summary>
    /// un patrat 3x3 in care sumele pe linii, coloane si diagonale sa fie egale (folosim permutari)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9; 
            int[] s = new int[n];
            bool[] b = new bool[n];
            BKsquare(0, n, s, b);
        }
        /*
        0 1 2
        3 4 5
        6 7 8
        */

        public static void BKsquare(int k, int n, int[] s, bool[] b)
        {//n!
            if (k >= n)
            {
                int sl1 = s[0] + s[1] + s[2];
                int sl2 = s[3] + s[4] + s[5];
                int sl3 = s[6] + s[7] + s[8];

                int sc1 = s[0] + s[3] + s[6];
                int sc2 = s[1] + s[4] + s[7];
                int sc3 = s[2] + s[5] + s[8];

                int sd1 = s[0] + s[4] + s[8];
                int sd2 = s[2] + s[4] + s[6];

                if (sl1 == sl2 && sl2 == sl3 && sl1 == sc1 && sl1 == sc2 && sl1 == sc3 && sl1 == sd1 && sl1 == sd2)
                {
                    for (int i = 0; i < n; i++)
                        if (i % 3 == 0)
                        {
                            Console.WriteLine();
                            Console.Write(s[i] + " ");

                        }
                        else
                        {
                            Console.Write(s[i] + " ");
                        }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        BKsquare(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }
    }
}
