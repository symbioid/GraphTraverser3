using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraverser3 {
    class Graph {

        private int size;
        private int[,] board;

        public Graph(int s) {
            size = s;            
            board = new int[,] { 
                { 2, 2, 2, 1 }, 
                { 2, 1, 1, 1 }, 
                { 1, 2, 2, 1 },                 
                { 2, 1, 1, 2 } };            

        }
        public void Display() {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
