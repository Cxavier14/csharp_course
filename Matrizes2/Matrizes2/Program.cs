using System;
using System.Collections.Generic;

namespace Matrizes2 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j  = 0; j < n; j++) {
                    if(mat[i,j] == x) {
                        Console.WriteLine($"Position {i},{j}");
                        if(i > 0) {
                            Console.WriteLine("Up: " + mat[i-1,j]);
                        }
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i,j-1]);
                        }
                        if (j < n-1) {
                            Console.WriteLine("Right: " + mat[i,j+1]);
                        }
                        if (i < m-1) {
                            Console.WriteLine("Down: " + mat[i+1,j]);
                        }
                    }
                }
            }
        }
    }
}
