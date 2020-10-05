using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {

            int numVertices = 0, numArestas = 0;
            Console.WriteLine("Numero de vertices");
            numVertices = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de arestas");
            numArestas = int.Parse(Console.ReadLine());
            int[,] grafo = new int[numVertices, numArestas];
            //string[] nomeVertices = new ;
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numArestas; j++)
                {
                    Console.WriteLine($"Confirme as ligações entre o vértice {i} e o vértice {j} com bits");
                    grafo[i, j] = int.Parse(Console.ReadLine());
                }
              
            }
            Console.WriteLine("O grafo representado em matrizes adjacentes é: ");
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numArestas; j++)
                {
                    Console.Write(grafo[i, j] + "\t");  
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

    }
}
