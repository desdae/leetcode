using System;

namespace CSharpSolutions._01500._01502
{
    public class Solution
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            if (arr.Length == 2)
                return true;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i + 1] - arr[i] != arr[i + 2] - arr[i + 1])
                    return false;
            }
            return true;
        }
    }
}
