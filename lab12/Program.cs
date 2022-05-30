using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    /// <summary>
    ///  se arunca 7 zaruri, afisati toate solutiile pt care exista cel putin 3 val identice
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[] s = new int[n];
            BK3id(0, n, s);
        }

        private static void BK3id(int niv, int n, int[] s)
        {
            if (niv < n)
            {
                for (int i = 0; i < 6; i++)
                {
                    s[niv] = i + 1;
                    BK3id(niv + 1, n, s);
                }
            }
            else
            {
                int nrId = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (s[i] == s[j])
                        {
                            nrId++;
                        }
                    }
                }
                if (nrId >= 3)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(s[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
