using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftProject
{
    internal class Utilities
    {
        //1
        public static bool IsPalindrome(string text)
        {
            if (text == null)
            {
                return false;
            }
            for (var i = 0; i < text.Length; i++)
            {
                if (text.ToLower()[i] == text.ToLower()[text.Length - 1 - i])
                {

                    return true;
                }
                Console.WriteLine("it's palindrome");
            }
            return true;
        }


        //2
        public static int MinSplit(int amount)
        {
            int count = 0;

            if (amount >= 50)
            {
                count = count + amount / 50;
                amount = amount % 50;
            }
            if (amount >= 20)
            {
                count = count + amount / 20;
                amount = amount % 20;
            }
            if (amount >= 10)
            {
                count += amount / 10;
                amount = amount % 10;
            }
            if (amount >= 5)
            {
                count += amount / 5;
                amount = amount % 5;
            }
            if (amount >= 1)
            {
                count += amount / 1;
                amount = amount % 1;
            }

            Console.WriteLine(amount);
            return count;
        }



        //3
        public static int NotContains(int[] array)
        {
            HashSet<int> set = new HashSet<int>(array);
            int min = 1;
            while (set.Contains(min))
            {
                min++;
            }
            return min;
        }


        //4
        public static bool IsProperly(string sequence)
        {
            var stack = new Stack<char>();
            foreach (char c in sequence)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false; 
                    }
                    char top = stack.Pop();
                    if (top != '(')
                    {
                        return false; 
                    }
                }
            }
            return stack.Count == 0; 
        }


        //5
        public static int CountVariants(int stairCount)
        {
            if (stairCount <= 1)
            {
                return 1;
            }
            int[] variants = new int[stairCount + 1];
            variants[0] = 1;
            variants[1] = 1;
            for (int i = 2; i <= stairCount; i++)
            {
                variants[i] = variants[i - 1] + variants[i - 2];
            }
            return variants[stairCount];
        }
    }
}
