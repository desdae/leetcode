using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01354
{
    public class Solution
    {
        public bool IsPossible(int[] target)
        {
            List<long> d = new List<long>();
            for (int i = 0; i < target.Length; i++)
            {
                d.Add(target[i]);
            }
            d.Sort();
            long max = d.Max();
            long sum = d.Sum();
            while (max > 1)
            {
                long diff = sum - max;
                long newv = max - diff;
                if (diff <= 0) break;                
                sum = sum - diff;
                d.Remove(max);
                d.Add(newv);
                d.Sort();
                max = d[d.Count - 1];
            }
            long min = d.Min();
            if (min == 1 && max == 1)
                return true;
            else
                return false;
        }
    }
}
