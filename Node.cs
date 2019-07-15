using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Node {
        
        static private int numEdges = 4;
        private Node[] targetNodes = new Node[4];
        public int NumEdges { get => numEdges; set => numEdges = value; }
        public Node[] TargetNodes  { get => targetNodes; set => targetNodes = value; }
        public int Value { get; set; }


        public Node(int v) {                   
            Value = v;                        
        }   
        
        public void AddTargetNode(int idx, ref Node tnode) {            
            TargetNodes[idx] = tnode;            
        }
    }
}