using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    class Solution
    {
        public string[] solution(string[] A)
        {
            List<string> list = new List<string>();
            string[] telNumbers;
            bool accepted = true;
            
            foreach (string word in A)
            {
                string[] partitions = word.Split('-');
                accepted = true;
                if (word.Length != 12)
                    continue;
                if (partitions[0].Length != 3 || partitions[1].Length != 3 || partitions[2].Length != 4)
                    continue;
                foreach(string partition in partitions)
                {                 
                    foreach (char c in partition)
                    {
                        if (!Char.IsDigit(c))
                        {
                            accepted = false;
                            break;
                        }                                                
                    }
                    if (accepted == false)
                        break;                  
                }
                if (accepted == true)
                    if (!list.Contains(word))
                        list.Add(word);
            }

            telNumbers = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
                telNumbers[i] = list.ElementAt<string>(i);
            return telNumbers;
        }

        public static void Main()
        {
            string[] phones = new String[4] { "123-456-7890", "000-000-0000", "000-000-0000", "12-345-678" };
            Solution s = new Solution();
            string[] nums = s.solution(phones);
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine("the proper phones are:  " + nums[i]);
            Console.ReadKey();
        }
    }
}
