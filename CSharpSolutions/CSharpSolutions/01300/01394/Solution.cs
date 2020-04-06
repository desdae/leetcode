using System;

namespace CSharpSolutions._01300._01394
{
    public class Solution
    {
        public int FindLucky(int[] arr)
        {
            int m = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                        c++;
                }
                if (c == arr[i])
                {
                    m = Math.Max(m, c);
                }
            }
            return m;
        }
    }
}
