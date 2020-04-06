using System.Numerics;

namespace CSharpSolutions._01400._01404
{
    public class Solution
    {
        public int NumSteps(string s)
        {
            BigInteger r = 0;

            foreach (char c in s)
            {
                r <<= 1;
                r += c == '1' ? 1 : 0;
            }
            int x = 0;
            while (r > 1)
            {
                if (r % 2 == 0)
                    r /= 2;
                else
                    r ++;
                x++;
            }
            return x;
        }
    }
}
