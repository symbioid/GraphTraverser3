using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Node {
        public int Val { get; set; }
        private int Visited;
        private Node[] TargetNodes = new Node[4];

        
        public Node(int v) {
            Val = v;            
        }   

        public void AddTargetNode(int idx, Node tnode) {
            TargetNodes[idx] = tnode;            
        }
    }
}