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
                    Board[i,j] = new Node(MoveValArray[i,j]);
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

        public void LinkNodes() {            
            for(int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {                    
                    for (int idx = 0; idx < Board[i, j].NumEdges; idx++) {                        
                        
                        //UP TARGET : SUB CURRENT NODE VALUE FROM CURRENT NODE VERT POSITION
                        // (I INDEX), IF NOT NULL, SET AS TARGET NODE, ELSE NULL.
                        if (Board[i - Board[i, j].Value, j] != null) {  
                            Board[i, j].AddTargetNode(idx, Board[i - Board[i, j].Value, j]);
                        }

                        //RIGHT TARGET: ADD CURRENT NODE VALUE FROM CURRENT NODE HORIZ POSITION
                        // (J INDEX), IF NOT NULL, SET AS TARGET NODE, ELSE NULL.
                        if (Board[i, j + Board[i, j].Value] != null) {
                            Board[i, j].AddTargetNode(idx, Board[i, j + Board[i, j].Value]);
                        }
                        //DOWN TARGET : ADD CURRENT NODE VALUE FROM CURRENT NODE VERT POSITION
                        // (I INDEX), IF NOT NULL, SET AS TARGET NODE, ELSE NULL.
                        if (Board[i + Board[i, j].Value, j] != null) {
                            Board[i, j].AddTargetNode(idx, Board[i + Board[i, j].Value, j]);
                        }
                        //LEFT TARGET : SUB CURRENT NODE VALUE FROM CURRENT NODE HORIZ POSITION
                        // (J INDEX), IF NOT NULL, SET AS TARGET NODE, ELSE NULL.
                        if (Board[i, j - Board[i, j].Value] != null) {
                            Board[i, j].AddTargetNode(idx, Board[i, j - Board[i, j].Value]);
                        }
                    }
                }
            }
        }
    }
}
