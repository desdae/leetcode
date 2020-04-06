using System;

namespace CSharpSolutions._01300._01385
{
    public class Solution
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int r = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                bool b = true;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (d >= Math.Abs(arr1[i] - arr2[j]))
                    {
                        b = false;
                        break;
                    }
                }
                if (b) r++;
            }
            return r;
        }
    }
}
