using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01346
{
    public class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] == arr[j] * 2 || arr[i] * 2 == arr[j])
                        return true;
            return false;
        }
    }
}
