using System;
using System.Linq;

namespace CSharpSolutions._01400._01460
{
    public class Solution
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);
            return Enumerable.SequenceEqual(target, arr);
        }
    }
}
