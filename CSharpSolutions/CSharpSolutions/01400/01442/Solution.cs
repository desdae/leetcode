namespace CSharpSolutions._01400._1442
{
    public class Solution
    {
        public int CountTriplets(int[] arr)
        {
            int n = arr.Length;
            int[,] xor = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int x = arr[i];
                xor[i, i] = x;
                for (int j = i + 1; j < n; j++)
                {
                    x = x ^ arr[j];
                    xor[i, j] = x;
                }
            }
            int r = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    for (int k = j; k < n; k++)
                        if (xor[i, j - 1] == xor[j, k])
                            r++;

            return r;
        }
    }
}
