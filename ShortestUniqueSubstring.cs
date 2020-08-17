using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestUniqueSubstring
{
    class Solution
    {
        public int solution(string S)
        {
            string temp;
 
            for (int i = 1; i < S.Length; i++)
            {
                for (int j = 0; j <= S.Length - i; j++)
                {
                    temp = S.Substring(j, i);
                    if (Unique(S, temp, j))
                    {
                        return temp.Length;
                    }
                }
            }

            return S.Length;
        }

        public bool Unique(string S, string A, int index)
        {
            int count = 0, i = 0;

            while ((i = S.IndexOf(A, i)) != -1)
            {
                count++;
                Console.WriteLine(A + " is found at " + S.Substring(i));
                i++;
            }

            if (count == 1)
                return true;
            return false;
        }

        public static void Main()
        {
            string S = "z";
            Solution s = new Solution();
            Console.WriteLine("The shortest unique substring length is " + s.solution(S).ToString());
            Console.ReadKey();
        }
    }
}
