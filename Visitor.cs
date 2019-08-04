using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Visitor {
        private Graph g;
        Queue<Node> WorkingQ = new Queue<Node>();
        public List<Node> Path = new List<Node>();
        public List<List<Node>> AllPaths = new List<List<Node>>();


        public Visitor(Node StartingNode) {
            if(StartingNode != null & StartingNode.Visited == false) {
                WorkingQ.Enqueue(StartingNode);
            }
        }




    }
}
