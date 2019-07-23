using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Walker {
        public Node CurrentNode;
        public List<Node> MoveList = new List<Node>();
        public int TotalPathCount = 0;
        public int MoveCount { get => MoveCount; set => MoveCount = 0; }
        
        public Walker(Node n) {
            CurrentNode = n;                 
            LogPosition(CurrentNode);
        }

        public void Move(Node TargetNode) {
            if (TargetNode.IsActive) {
                CurrentNode.IsActive = false;
                CurrentNode = TargetNode;
                LogPosition(CurrentNode);
            }
            else {
                TotalPathCount += 1;
                Console.WriteLine($"Path # {TotalPathCount}:");
                Console.WriteLine($"Total Moves in Path: {MoveCount}");

                for (int i = 0; i < MoveCount; i++) {
                    Console.WriteLine($"{MoveCount}: {MoveList[i].Location}");
                }
                return;
            }
        }

        public void LogPosition(Node n) {
            MoveList.Add(n);
            MoveCount++;
        }
        
    }
}
