using System.Collections.Generic;

namespace CSharpSolutions._01300._01386
{
    public class Solution
    {
        public class Row
        {
            public bool b1;
            public bool b2;
            public bool b3;

            public Row()
            {
                b1 = true;
                b2 = true;
                b3 = true;
            }

            public void Reserve(int x)
            {
                if (x >= 2 && x <= 5) b1 = false;
                if (x >= 4 && x <= 7) b2 = false;
                if (x >= 6 && x <= 9) b3 = false;
            }

            public int Count()
            {
                if (b1 && b3) return 2;
                if (b1 || b2 || b3) return 1;
                return 0;
            }
        }
        public int MaxNumberOfFamilies(int n, int[][] reservedSeats)
        {
            Dictionary<int, Row> rows = new Dictionary<int, Row>();
            int res = n * 2;
            for (int i = 0; i < reservedSeats.Length; i++)
            {
                if (!rows.ContainsKey(reservedSeats[i][0]))
                {
                    rows[reservedSeats[i][0]] = new Row();
                }
                rows[reservedSeats[i][0]].Reserve(reservedSeats[i][1]);
            }

            foreach (var r in rows.Values)
            {
                res = res - 2 + r.Count();
            }
            return res;
        }
    }
}
