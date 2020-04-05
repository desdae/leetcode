using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01356
{
    public class Solution
    {
        public int[] SortByBits(int[] arr)
        {
            int s = arr.Length;
            Array.Sort(arr, (int a, int b) => {
                string A = Convert.ToString(a, 2);
                string B = Convert.ToString(b, 2);
                int ac = 0, bc = 0;
                for (int i = 0; i < A.Length; i++)
                    if (A[i] == '1') ac++;
                for (int i = 0; i < B.Length; i++)
                    if (B[i] == '1') bc++;
                int res = ac - bc;
                if (res == 0)
                    res = a - b;
                return res;
            });
            return arr;
        }
    }
}
