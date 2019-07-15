using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Graph {

        private int Size;
        private int[,] MoveValArray;
        private Node[,] Board;

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
                }
            }
        }    
        
        public void Display() {
            for (int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {
                    Console.Write(Board[i, j].Value + " ");
                }
                Console.WriteLine();
            }
        }

        public void DisplayEachNodesConnections() {
            for(int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {
                    Board[i,j].DisplayTargetNodes();
                }
            }
        }

        public void LinkNodes() {
            for (int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {
                    for (int idx = 0; idx < Board[i, j].NumEdges; idx++) {
                        int movevalue = Board[i, j].Value;

                        if (idx == 0) {    
                            if (i - movevalue < 0) {
                                Board[i, j].TargetNodes[idx] = null;
                            }
                            else { 
                                Board[i, j].AddTargetNode(idx, Board[i - movevalue, j]);
                            }
                        }

                        if (idx == 1) {
                            if (j + movevalue >= Size) {
                                Board[i, j].TargetNodes[idx] = null;
                            }
                            else {
                                Board[i, j].AddTargetNode(idx, Board[i, j + movevalue]);
                            }
                        }

                        if (idx == 2) {
                            if (i + movevalue >= Size) {
                                Board[i, j].TargetNodes[idx] = null;
                                
                            } else {
                                Board[i, j].AddTargetNode(idx, Board[i + movevalue, j]);
                            }
                        }

                        if (idx == 3) {
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
    }
}
