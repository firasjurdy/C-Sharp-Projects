using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOccurance
{
    class Solution
    {
        public void sort(int[] A)
        {
            int size = A.Length;
            for (int i = size / 2 - 1; i >= 0; i--)
                heapify(A, size, i);
            for (int i = size - 1; i >= 0; i--)
            {
                int temp = A[0];
                A[0] = A[i];
                A[i] = temp;
                heapify(A, i, 0);
            }
        }

        void heapify(int[] A, int size, int index)
        {
            int largest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            if (left < size && A[left] > A[largest])
                largest = left;
            if (right < size && A[right] > A[largest])
                largest = right;
            if (largest != index)
            {
                int swap = A[index];
                A[index] = A[largest];
                A[largest] = swap;
                heapify(A, size, largest);
            }
        }
        public int solution(int[] A)
        {
            int temp, count = 1;

            sort(A);

            int i = A.Length, j;

            while (i > 0)
            {
                count = 1;
                temp = A[i - 1];
                for (j = i - 2; j >= 0; j--)
                {
                    if (A[j] != temp)
                        break;
                    count++;
                }

                i = j + 1;

                if (count == temp)
                    return count;
            }

            return 0;
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
            int[] arr = { 1, 2, 1, 4, 2, 3, 5, 5, 3, 4, 3 };
            Solution s = new Solution();
            int num = s.solution(arr);
            Console.WriteLine(num.ToString() + " is the largest number that appears  " + num.ToString() + " times");
            Console.WriteLine("\nSorted array is");
            printArray(arr);
        }
    }
}
