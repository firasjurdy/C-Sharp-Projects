using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonPrimeDivisors
{
    class Solution
    {
        public int solution(int[] A, int[] B)
        {           
            List<int> listA = new List<int>();
            List<int> listB = new List<int>();
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                listA = FindPrimeDivisors(A[i]);
                listB = FindPrimeDivisors(B[i]);              
                if (AreEqual(listA, listB))
                    count++;
            }
            
            return count;
        }

        public bool IsPrime(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }

            for (int a = 2; a <= num / 2; a++)
            {
                if (num % a == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public List<int> FindPrimeDivisors(int num)
        {
            List<int> l = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (IsPrime(i))
                        l.Add(i);
                }
            }

            return l;
        }

        public bool AreEqual(List<int> listA, List<int> listB)
        {
            if (listA.Count != listB.Count)
                return false;

            for (int i = 0; i < listA.Count; i++)
            {
                if (listA[i] != listB[i])
                    return false;
            }

            return true;
        }

        public static void Main()
        {
            int[] A = { 15, 10, 3 };
            int[] B = { 75, 30, 5 };
            Solution s = new Solution();
            Console.WriteLine("the number of positions for which the prime divisors of A and B are exactly the same is:  " + s.solution(A, B).ToString());
            Console.Read();
        }
    }
}
