using System.Collections.Generic;

namespace CSharpSolutions._01400._01411
{
    public class Solution
    {
        private int m = 1000000007;

        public class Row
        {
            public int a;
            public int b;
            public int c;

            public bool IsOk(Row prev)
            {
                return (a != prev.a && b != prev.b && c != prev.c);
            }
        }

        private List<Row> combos;

        private int[,,,] dp = new int[3, 3, 3, 5005];

        private void GenerateCombos()
        {
            combos = new List<Row>();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        if (i != j && j != k)
                            combos.Add(new Row() { a = i, b = j, c = k });
        }

        public int NumOfWays(int n)
        {
            GenerateCombos();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < combos.Count; j++)
                {
                    if (i == 1)
                    {
                        dp[combos[j].a, combos[j].b, combos[j].c, i] = 1;
                    }
                    else
                    {
                        int t = 0;

                        for (int k = 0; k < combos.Count; k++)
                        {
                            if (combos[j].IsOk(combos[k]))
                            {
                                t += dp[combos[k].a, combos[k].b, combos[k].c, i - 1];
                                t %= m;
                            }
                        }
                        dp[combos[j].a, combos[j].b, combos[j].c, i] = t;
                    }
                }
            }

            long res = 0;
            for (int i = 0; i < combos.Count; i++)
            {
                res = (res + dp[combos[i].a, combos[i].b, combos[i].c, n]) % m;
            }

            return (int)res;
        }
    }
}
