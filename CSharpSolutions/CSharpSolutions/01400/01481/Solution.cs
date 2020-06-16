
using System.Collections.Generic;
using System.Linq;


namespace CSharpSolutions._01400._01481
{
    public class Solution
    {
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            var d = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!d.ContainsKey(arr[i]))
                    d[arr[i]] = 0;
                d[arr[i]]++;
            }
            var cnt = 0;
            int rem = 0;
            bool border = false;
            foreach (var e in d.OrderBy(x => x.Value))
            {
                if (rem + e.Value <= k)
                {
                    rem += e.Value;
                }
                else
                {
                    if (!border)
                    {
                        border = true;
                        if (rem + e.Value > k)
                            cnt++;
                    }
                    else
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }
}
