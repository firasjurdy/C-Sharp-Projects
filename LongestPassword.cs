using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPassword
{
    class Solution
    {
        public int solution(string S)
        {
            int max = -1;
            bool accepted = true;
            string[] words = S.Split(' ');
            foreach ( string word in words)
            {             
                accepted = true;
                foreach (char c in word)
                {
                    if (!Char.IsDigit(c) && !Char.IsLetter(c))
                        accepted = false;
                    if (word.Count(char.IsLetter) % 2 != 0)
                        accepted = false;
                    if (word.Count(char.IsDigit) % 2 == 0)
                        accepted = false; 
                }
                if (accepted == true)
                    if (max < word.Length)
                        max = word.Length;
                if (accepted == true)
                    Console.WriteLine(word + " is accepted");
                else Console.WriteLine(word + " is not accepted");
            }
            
            return max;
        }

        public static void Main()
        {
           string password = "test 5 a0A pass007 ?xy1";
            Solution s = new Solution();
            Console.WriteLine("the length of the longest word from the string that is a valid password is:  " + s.solution(password).ToString());
            Console.ReadKey();
        }
    }
}
