using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00000._00070
{
    public class Solution
    {
        private Dictionary<int, int> dp = new Dictionary<int, int>();
        
        private int Calc(int n)
        {
            if (dp.ContainsKey(n))
                return dp[n];
            int res = 0;
            if (n == 1)
                res = 1;
            else if (n == 2)
                res = 2;
            else
                res = Calc(n - 2) + Calc(n - 1);
            dp[n] = res;
            return res;
        }
        public int ClimbStairs(int n)
        {
            dp.Clear();
            return Calc(n);
        }
    }
}
