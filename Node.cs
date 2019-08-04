using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Node {

        public Tuple<int, int> Location { get; set; }

        static private int numEdges = 4;
        public int NumEdges { get; } = numEdges;

        private Node[] targetNodes = new Node[numEdges];
<<<<<<< HEAD
        private bool visited;

        public Node[] TargetNodes  { get => targetNodes; set => targetNodes = value; }        
        public bool Visited { get => visited; set => visited = false; }

        public int Value { get; set; }
        
        public Node(Tuple<int,int> location, int value) {
            Location = location;
            Value = value;                        
=======
        public Node[] TargetNodes  { get => targetNodes; set => targetNodes = value; }

        
        public bool IsActive { get; set; }
        public int Value { get; set; }

        public Node(Tuple<int,int> l, int v) {
            Location = l;
            Value = v;                        
>>>>>>> parent of abdd838... More Walker Class / Refactor / Add More Output upon reaching path end. (Still not called/tested)
        }   

        public void Display() {
            Console.Write(Value);
        }
        
        public void AddTargetNode(int idx, Node tnode) {            
            TargetNodes[idx] = tnode;            
        }

        public void DisplayTargetNodes() {
            String[] Direction = { "Up", "Right", "Down", "Left" };

            for (int i = 0; i < NumEdges; i++) {
                Console.Write($"Node {Location}'s {Direction[i]} Node is: ");
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
