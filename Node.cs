using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Node {

        public Tuple<int, int> Location { get; set; }
        
        static private int numEdges = 4;        
        public int NumEdges { get => numEdges; set => numEdges = value; }

        private Node[] targetNodes = new Node[4];
        public Node[] TargetNodes  { get => targetNodes; set => targetNodes = value; }

        private bool isActive = true;
        public bool IsActive { get => isActivate; set => isActive = value; }
        public int Value { get; set; }
        
        

        public Node(Tuple<int,int> l, int v) {
            Location = l;
            Value = v;                        
        }   

        public void Display() {
            Console.Write(Value);
        }
        
        public void AddTargetNode(int idx, Node tnode) {            
            TargetNodes[idx] = tnode;            
        }

        public void DisplayTargetNodes() {

            String Direction = "";

            for (int i = 0; i < NumEdges; i++) {
                if (i == 0) {
                    Direction = "Up";
                } 
                if (i == 1) {
                    Direction = "Right";
                }
                if (i == 2) {
                    Direction = "Down";
                }
                if (i == 3) {
                    Direction = "Left";
                }           

                Console.Write($"Node {Location}'s {Direction} Node is: ");
                if (TargetNodes[i] == null) {                    
                    Console.WriteLine("A NULL NODE");
                    
                } else {
                    Console.WriteLine($"at {TargetNodes[i].Location}, with a value of {TargetNodes[i].Value}");
                    
                }                
            }
            Console.WriteLine("------------------");
        }
    }
}
