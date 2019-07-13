using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Graph {

        private int size;
        private int[,] board;
        private Node[,] board2;

        public Graph(int s) {
            size = s;            
            board = new int[,] { 
                { 2, 2, 2, 1 }, 
                { 2, 1, 1, 1 }, 
                { 1, 2, 2, 1 },                 
                { 2, 1, 1, 2 }
            };

            board2 = new Node[size, size];  
            
            for (int i = 0; i < s; i++) {
                for (int j = 0; j < s; j++) {
                    board2[i,j] = new Node(board[i,j]);
                }
            }
        }    
        
        public void Display() {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    Console.Write(board2[i, j].Val + " ");
                }
                Console.WriteLine();
            }
        }

        public void BuildEdges() {
            
        }
    }
}
