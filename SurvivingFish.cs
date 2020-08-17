using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishSuvival
{
    class Solution
    {
        public int solution(int[] A, int[] B)
        {
            Stack<int> s = new Stack<int>();
            List<int> l = new List<int>();
            int index;

            for (int i = 0; i < A.Length; i++)
            {
                l.Add(i);
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                    s.Push(i);
            }

            while (s.Count > 0)
            {
                index = s.Peek();
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (l.Contains(i) && B[i] == 0)
                    {
                        if (A[index] > A[i])
                        {
                            l.Remove(i);
                        }
                        else
                        {
                            l.Remove(index);
                        }
                    }                  
                }
                s.Pop();
            }
            
            return l.Count;
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
            int[] arr = { 4, 3, 2, 1, 5 };
            int[] b = { 0, 1, 0, 1, 0 };
            Solution s = new Solution();
            Console.WriteLine("Thne number of fish that are still alive is:  " + s.solution(arr, b).ToString());
            Console.WriteLine("\narray is");
            printArray(arr);
        }
    }
}
