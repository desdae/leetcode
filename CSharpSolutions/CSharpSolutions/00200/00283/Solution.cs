namespace CSharpSolutions._00200._00283
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int n = nums.Length;
            int p = 0;
            int zc = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                    zc++;
                else
                    nums[p++] = nums[i];
            }
            for (int i = n - 1; i >= n - zc; i--)
            {
                nums[i] = 0;
            }
        }
    }
}
