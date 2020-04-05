namespace CSharpSolutions._01300._01359
{
    public class Solution
    {
        public int CountOrders(int n)
        {
            int m = 1;
            long res = 1;
            for (int i = 1; i < n * 2 - 1; i += 2)
            {
                m += 2 * i + 3;
                res = (res * m) % 1000000007;
            }
            return (int)res;
        }
    }
}
