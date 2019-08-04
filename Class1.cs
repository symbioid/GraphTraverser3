using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
<<<<<<< HEAD:Class1.cs
    class Class1 {
=======
    class Walker {
        public Node StartNode;
        public Node CurrentNode;
        public Graph graph;
        public List<Node> MoveList = new List<Node>();

        public int MoveCount { get => MoveCount; set => MoveCount = 0; }
        
        public Walker(Tuple<int, int> StartPosition, Node n) {
            StartNode = n;            
            LogPosition(StartNode);
        }

        public void Move(Node TargetNode) {
            if (TargetNode.IsActive == true) {
                CurrentNode.IsActive = false;
                CurrentNode = TargetNode;
                MoveCount++;
            }
            else {
                Console.WriteLine("EOL");
                return;
            }
        }

        public void LogPosition(Node n) {
            MoveList.Add(n);
        }
>>>>>>> parent of abdd838... More Walker Class / Refactor / Add More Output upon reaching path end. (Still not called/tested):Walker.cs
    }
}
