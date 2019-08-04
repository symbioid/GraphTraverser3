using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Program {
        static void Main(string[] args) {
<<<<<<< HEAD
            public static Graph g = new Graph(4);
            Visitor v = new Visitor(g.Board[0,0]);
=======
            Graph g = new Graph(4);
>>>>>>> parent of abdd838... More Walker Class / Refactor / Add More Output upon reaching path end. (Still not called/tested)
            g.Display();
            g.LinkNodes();
            Console.WriteLine();
            g.DisplayEachNodesConnections();
<<<<<<< HEAD

=======
>>>>>>> parent of abdd838... More Walker Class / Refactor / Add More Output upon reaching path end. (Still not called/tested)
            Console.Read();
        }
    }
}

