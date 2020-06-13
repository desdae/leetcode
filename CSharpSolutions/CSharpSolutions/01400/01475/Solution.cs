
namespace CSharpSolutions._01400._01475
{
    public class Solution
    {
        public int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                var p = prices[i];
                int m = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (p >= prices[j])
                    {
                        m = prices[j];
                        break;
                    }
                }
                prices[i] = p - m;
            }
            return prices;
        }
    }
}
