using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day12
{
    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {            
            Array.Sort(stones);
            int n = stones.Length;
            while (n > 1 && stones[n - 2] > 0 )
            {                
                stones[n - 1] = Math.Abs(stones[n - 1] - stones[n - 2]); 
                stones[n - 2] = 0;
                Array.Sort(stones);
            }
            return stones[n - 1];
        }
    }
}
