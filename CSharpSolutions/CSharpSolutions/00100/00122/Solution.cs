namespace CSharpSolutions._00100._00122
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int r = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    r += prices[i] - prices[i - 1];
            }
            return r;
        }
    }
}
