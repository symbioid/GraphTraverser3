using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Node {
        public int Value { get; set; }
        private int numEdges = 4;
        public int NumEdges { get => numEdges; set => numEdges = value; }

        private int Visited;
        
        private Node[] TargetNodes;

        
        public Node(int v) {           
            Value = v;                        
        }   
        
        public void AddTargetNode(int idx, Node tnode) {
            
            TargetNodes[idx] = tnode;            
        }
    }
}