using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Graph {

        public int size;
        public Node node;


        public Graph(int s) {
            size = s;
            node = new Node(s);
            
        }
        public void Display() {            
                Console.WriteLine(node.val);            
        }
    }
}
