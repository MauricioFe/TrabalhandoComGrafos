using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grafo = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grafo[i, j]);
                    if (j == 2)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
