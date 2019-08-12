using System;
using System.Collections.Generic;

namespace GraphTraverser3 {
    class Walker {
        public Node StartNode;
        public Node CurrentNode;
        public Graph graph;
        public bool IsActive { set; get; }
        public List<Node> NodeList = new List<Node>();
        private Queue <Node> NodeQueue = new Queue<Node>();       
        
        public Walker(Tuple<int, int> StartPosition, Node n) {
            IsActive = true;
            StartNode = n;            
        }
        public void LogPosition(Node n) {
            NodeList.Add(n);            
        }

        public EnqueueCurrentAndAdjacentNodes(Node n) {
            NodeQueue.Enqueue(n);
        }
    }
}
