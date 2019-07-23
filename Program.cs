using System;


namespace GraphTraverser3 {
    class Program {
        static void Main(string[] args) {
            Graph g = new Graph(4);            
            g.Display();
            g.LinkNodes();
            Console.WriteLine();                        
            g.DisplayAllNodesAndTargets();            
            Console.Read();
        }
    }
}

