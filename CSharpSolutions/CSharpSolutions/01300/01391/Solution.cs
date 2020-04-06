namespace CSharpSolutions._01300._01391
{
    public class Solution
    {
        public bool HasValidPath(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int j = 0;
            int i = 0;
            int di = -1;
            while (true)
            {
                int g = grid[j][i];

                if (j == m - 1 && i == n - 1)
                    return true;

                if (g == 1)
                {
                    if (di == -1) di = 0;
                    if (di == 0)
                    {
                        //right
                        if (i + 1 == n) return false;
                        if (grid[j][i + 1] == 1 || grid[j][i + 1] == 3 || grid[j][i + 1] == 5)
                        {
                            i++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        //left
                        if (i - 1 == -1) return false;
                        if (grid[j][i - 1] == 1 || grid[j][i - 1] == 2 || grid[j][i - 1] == 4)
                        {
                            i--;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (g == 2)
                {
                    if (di == -1) di = 1;
                    if (di == 1)
                    {
                        //down
                        if (j + 1 == m) return false;
                        if (grid[j + 1][i] == 2 || grid[j + 1][i] == 5 || grid[j + 1][i] == 6)
                        {
                            j++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        //up
                        if (j - 1 == -1) return false;
                        if (grid[j - 1][i] == 2 || grid[j - 1][i] == 3 || grid[j - 1][i] == 4)
                        {
                            j--;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (g == 3)
                {
                    if (di == -1) di = 0;
                    if (di == 0)
                    {
                        //down
                        if (j + 1 == m) return false;
                        if (grid[j + 1][i] == 2 || grid[j + 1][i] == 5 || grid[j + 1][i] == 6)
                        {
                            j++;
                            di = 1;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        //left
                        if (i - 1 == -1) return false;
                        if (grid[j][i - 1] == 1 || grid[j][i - 1] == 2 || grid[j][i - 1] == 4)
                        {
                            i--;
                            di = 2;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (g == 4)
                {
                    if (di == -1) di = 2;
                    if (di == 3)
                    {
                        //right
                        if (i + 1 == n) return false;
                        if (grid[j][i + 1] == 1 || grid[j][i + 1] == 3 || grid[j][i + 1] == 5)
                        {
                            di = 0;
                            i++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        //down
                        if (j + 1 == m) return false;
                        if (grid[j + 1][i] == 2 || grid[j + 1][i] == 5 || grid[j + 1][i] == 6)
                        {
                            j++;
                            di = 1;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (g == 5)
                {
                    if (di == 1)
                    {
                        //left
                        if (i - 1 == -1) return false;
                        if (grid[j][i - 1] == 1 || grid[j][i - 1] == 2 || grid[j][i - 1] == 4)
                        {
                            i--;
                            di = 2;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        //up
                        if (j - 1 == -1) return false;
                        if (grid[j - 1][i] == 2 || grid[j - 1][i] == 3 || grid[j - 1][i] == 4)
                        {
                            j--;
                            di = 3;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (g == 6)
                {
                    if (di == -1) di = 1;
                    if (di == 1)
                    {
                        //right
                        if (i + 1 == n) return false;
                        if (grid[j][i + 1] == 1 || grid[j][i + 1] == 3 || grid[j][i + 1] == 5)
                        {
                            di = 0;
                            i++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        //up
                        if (j - 1 == -1) return false;
                        if (grid[j - 1][i] == 2 || grid[j - 1][i] == 3 || grid[j - 1][i] == 4)
                        {
                            j--;
                            di = 3;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

            }
        }
    }
}
