
namespace CSharpSolutions._01400._01486
{
    class Solution
    {
        public int XorOperation(int n, int start)
        {
            var x = start;
            for (int i = 1; i < n; i++)
            {
                x = x ^ (start + i * 2);
            }
            return x;
        }
    }
}
