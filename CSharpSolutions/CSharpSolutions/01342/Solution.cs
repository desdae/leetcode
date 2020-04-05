using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01342
{
    public class Solution
    {
        public int NumberOfSteps(int num)
        {
            int steps = 0;
            while (num > 0)
            {
                if (num % 2 == 0) num /= 2;
                else num--;
                steps++;
            }
            return steps;
        }
    }
}
