﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laf14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph theGraph = new Graph();
            theGraph.addVertex('A'); // 0 
            theGraph.addVertex('B'); // 1
            theGraph.addVertex('C'); // 2
            theGraph.addVertex('D'); // 3
            theGraph.addVertex('E'); // 4

            theGraph.addEdge(0, 1, 50); // AB 50
            theGraph.addEdge(0, 3, 80); // AD 80
            theGraph.addEdge(1, 2, 60); // BC 60
            theGraph.addEdge(1, 3, 90); // BD 90
            theGraph.addEdge(2, 4, 40); // CE 40
            theGraph.addEdge(3, 2, 20); // DC 20
            theGraph.addEdge(3, 4, 70); // DE 70
            theGraph.addEdge(4, 1, 50); // EB 50

            Console.WriteLine("Shortest paths");
            theGraph.path();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
