using System;


namespace GraphTraverser3 {
    class Graph {

        public  int Size { get; }
        private int[,] MoveValArray;
        public Node[,] Board { get; }

        public Graph(int s) {
            Size = s;      
            
            MoveValArray = new int[,] { 
                { 2, 2, 2, 1 }, 
                { 2, 1, 1, 1 }, 
                { 1, 2, 2, 1 },                 
                { 2, 1, 1, 2 }
            };

            Board = new Node[Size, Size];           
            for (int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {
                    var Loc = Tuple.Create(i, j);
                    Board[i,j] = new Node(Loc, MoveValArray[i,j]);
                    Board[i,j].Visited = false;
                }
            }
        }           
        public void LinkNodes() {
            for (int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {
                    // loop through each cardinal direction
                    // and set target nodes:

                    for (int idx = 0; idx < Board[i, j].NumEdges; idx++) {
                        int movevalue = Board[i, j].Value;

                        if (idx == 0) {    // CHECK UP
                            if (i - movevalue < 0) {
                                Board[i, j].TargetNodes[idx] = null;
                            }
                            else { //Derive these params from return of MoveVector function;
                                Board[i, j].AddTargetNode(idx, Board[i - movevalue, j]);
                            }
                        }

                        if (idx == 1) { // CHECK RIGHT
                            if (j + movevalue >= Size) {
                                Board[i, j].TargetNodes[idx] = null;
                            }
                            else { //Derive these params from return of MoveVector function;
                                Board[i, j].AddTargetNode(idx, Board[i, j + movevalue]);
                            }
                        }

                        if (idx == 2) { // CHECK DOWN
                            if (i + movevalue >= Size) {
                                Board[i, j].TargetNodes[idx] = null;

                            }
                            else { //Derive these params from return of MoveVector function;
                                Board[i, j].AddTargetNode(idx, Board[i + movevalue, j]);
                            }
                        }

                        if (idx == 3) { // CHECK LEFT
                            if (j - movevalue < 0) {
                                Board[i, j].TargetNodes[idx] = null;

                            }
                            else {
                                Board[i, j].AddTargetNode(idx, Board[i, j - movevalue]);
                            }
                        }
                    }
                }
            }
        }

        public void Display() {
            for (int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {
                    Board[i, j].Display();
                    if (j < Size-1) {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void DisplayAllNodesAndTargets() {
            for(int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {
                    Board[i,j].DisplayTargetNodes();
                }
            }
        }
        
    }
}
