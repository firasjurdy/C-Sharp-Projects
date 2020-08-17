using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverJump
{
    class Solution
    {      
        public int solution(int X, int[] A)
        {
            if (X > A.Length)
                return -1;
            int max = 0;
            int maxIndex = -1;
            int[] B = new int[X+1];
            for (int i = 0; i < X+1; i++)
                B[i] = -1;
            for (int i = 0; i < A.Length; i++)
            {
                B[A[i]] = 1;
                if (max < A[i])
                {
                    max = A[i];
                    maxIndex = i;
                }                   
            }
            for (int i = 1; i < X+1; i++)
                if (B[i] == -1)
                {
                    return -1;
                }
            return maxIndex;
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.Read();
        }

        public static void Main()
        {
            int[] arr = { 1, 5, 1, 1, 2, 3, 3, 4 };
            int x = 5;
            Solution s = new Solution();
            int time = s.solution(x, arr);
            if ( time == -1)
            {
                Console.WriteLine("No Path");
            }
            else Console.WriteLine("At time " + time.ToString() + ", the frog can reach the other side of the river");

            Console.WriteLine("\narray is");
            printArray(arr);
        }
    }
}
