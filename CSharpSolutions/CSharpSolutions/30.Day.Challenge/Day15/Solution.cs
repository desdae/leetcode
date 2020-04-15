using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day15
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] r = new int[n];
            r[0] = 1;
            for (int i = 1; i < n; i++)
            {
                r[i] = r[i - 1] * nums[i - 1];
            }
            int rt = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                r[i] *= rt;
                rt *= nums[i];
            }
            return r;
        }
    }
}
