namespace CSharpSolutions._01300._01389
{
    public class Solution
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            int n = nums.Length;
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > index[i]; j--)
                {
                    res[j] = res[j - 1];
                }
                res[index[i]] = nums[i];
            }
            return res;
        }
    }
}
