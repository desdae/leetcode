using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._00200._00264
{
    public class SolutionBruteForceTLE //n = 500; ugly = 937500
    {
        private bool IsUgly(int n)
        {
            if (n == 1)
                return true;
            while (n % 2 == 0)
                n /= 2;
            while (n % 3 == 0)
                n /= 3;
            while (n % 5 == 0)
                n /= 5;
            return n == 1;
        }
        public int NthUglyNumber(int n)
        {
            int c = 0;
            int x = 0;
            while (x < n)
            {
                c++;
                if (IsUgly(c))
                {
                    x++;
                    Console.WriteLine(c);
                }
            }
            return c;
        }
    }

    public class Solution
    {
        private HashSet<long> nums = new HashSet<long>(); 
        
        private void DFS(long n)
        {
            if (n > int.MaxValue)
                return;
            if (nums.Contains(n))
                return;
            nums.Add(n);
            DFS(n * 2);
            DFS(n * 3);
            DFS(n * 5);
        }
        
        public int NthUglyNumber(int n)
        {
            DFS(1);
            var list = nums.ToList();
            list.Sort();
            return (int)list[n - 1];
        }
    }
}
