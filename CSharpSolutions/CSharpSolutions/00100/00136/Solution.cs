using System.Linq;

namespace CSharpSolutions._00100._00136
{
    public class Solution
    {
        public int SingleNumber(int[] nums) => nums.Aggregate(0, (a, x) => a ^ x);
    }
}
