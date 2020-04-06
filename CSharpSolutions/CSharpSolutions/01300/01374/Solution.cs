using System;
using System.Text;


public class Solution
{
    public string GenerateTheString(int n)
    {
        var res = new StringBuilder();
        if (n % 2 == 1)
        {
            for (int i = 0; i < n; i++)
            {
                res.Append('g');
            }
        }
        else
        {
            for (int i = 0; i < n - 1; i++)
            {
                res.Append('g');
            }
            res.Append('x');
        }
        return res.ToString();
    }
}