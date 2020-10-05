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
            //Inicializa o numero de vértices e de arestas
            int numVertices = 0, numArestas = 0;
            Console.WriteLine("Numero de vertices");
            numVertices = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de arestas");
            numArestas = int.Parse(Console.ReadLine());
            //Cria uma matriz adjacente de n x n
            int[,] grafo = new int[numVertices, numArestas];
            //vetor para nomear os vértices
            string[] nomeVertices = new string[numVertices];
            for (int i = 0; i < numVertices; i++)
            {
                Console.WriteLine("digite o nome do vértice");
                nomeVertices[i] = Console.ReadLine();
            }
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numArestas; j++)
                {
                    Console.WriteLine($"Confirme as ligações entre o vértice '{nomeVertices[i]}' e o vértice '{nomeVertices[j]}' com bits. 1 para quando houver ligações e 0 para quando não houver");
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
