namespace CSharpSolutions._00000._00074
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null) return false;
            int n = matrix.Length;
            if (n == 0) return false;
            int m = matrix[0].Length;
            if (m == 0) return false;
            int r = 0;
            while (r < n && target > matrix[r][m - 1])
                r++;
            if (r == n) return false;
            int s = 0;
            int e = m - 1;
            while (s <= e)
            {
                int md = s + (e - s) / 2;
                if (matrix[r][md] == target) return true;
                else if (target > matrix[r][md]) s++;
                else e--;
            }
            return false;
        }
    }
}
