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
            for (int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {
                    for (int idx = 0; idx < Board[i, j].NumEdges; idx++) {
                        int movevalue = Board[i, j].Value;

                        //UP TARGET : SUB CURRENT NODE VALUE FROM CURRENT NODE VERT POSITION
                        // (I INDEX), IF NOT NULL, SET AS TARGET NODE, ELSE NULL.
                        if (i - movevalue >= 0) {
                            Board[i, j].AddTargetNode(idx, ref Board[i - movevalue, j]);
                        }

                        //RIGHT TARGET: ADD CURRENT NODE VALUE FROM CURRENT NODE HORIZ POSITION
                        // (J INDEX), IF NOT NULL, SET AS TARGET NODE, ELSE NULL.
                        if (j + movevalue < Size) {
                            Board[i, j].AddTargetNode(idx, ref Board[i, j + movevalue]);
                        }
                        //DOWN TARGET : ADD CURRENT NODE VALUE FROM CURRENT NODE VERT POSITION
                        // (I INDEX), IF NOT NULL, SET AS TARGET NODE, ELSE NULL.
                        if (i + movevalue < Size) {
                            Board[i, j].AddTargetNode(idx, ref Board[i + movevalue, j]);
                        }
                        //LEFT TARGET : SUB CURRENT NODE VALUE FROM CURRENT NODE HORIZ POSITION
                        // (J INDEX), IF NOT NULL, SET AS TARGET NODE, ELSE NULL.
                        if (j - movevalue >= 0) {
                            Board[i, j].AddTargetNode(idx, ref Board[i, j - movevalue]);
                        }
                    }
                }
            }
        }
        /*
        public void LinkNodes() {
            int i = 2;
            int j = 0;
            int movevalue = Board[i, j].Value;

            Console.WriteLine($"i = {i}, j = {j}");
            Console.WriteLine($"MoveValue = {movevalue}");

            if (i - movevalue < 0) {
                Console.WriteLine($"current i of {i} - movevalue = {i - movevalue}");
                Console.WriteLine($"Target Node Location = {i - movevalue}, {j}");
                Console.WriteLine("FAIL!");
            }
            else {
                Console.WriteLine($"current i ({i}) - movevalue ({movevalue}) = {i - movevalue}");
                Console.WriteLine("SUCCESS!");
                Console.WriteLine($"Target Node Location = {i-movevalue}, {j}");                
                Console.WriteLine($"Target Node Value: {Board[i - movevalue, j].Value}");
                Node n = Board[i - movevalue, j];
                Console.WriteLine($"Node n movevalue is : {n.Value}");
                Board[i, j].AddTargetNode(0, ref n);
                Console.WriteLine($"TARGET NODE VALUE: {Board[i, j].TargetNodes[0].Value}");
            }
        }*/
    }
}
