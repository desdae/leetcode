using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01295
{
    public class Solution
    {
        public int FindNumbers(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i].ToString().Length % 2 == 0)
                    res++;
            return res;
        }
    }
}
