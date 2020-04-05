using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01365
{
    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var res = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                        c++;
                }
                res.Add(c);
            }
            return res.ToArray();
        }
    }
}
