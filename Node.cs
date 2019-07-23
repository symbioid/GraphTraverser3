using System;


namespace GraphTraverser3 {
    class Node {

        public Tuple<int, int> Location { get; set; }

        static private int numEdges = 4;
        public int NumEdges { get; } = numEdges;
        public bool Visited { get; set; }
        public int Value { get; set; }

        private Node[] targetNodes = new Node[numEdges];
        public Node[] TargetNodes  { get => targetNodes; set => targetNodes = value; }        
        

        public Node(Tuple<int,int> location, int value) {
            Location = location;
            Value = value;                        
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
