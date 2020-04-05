using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01353
{
    public class Solution
    {
        public int MaxEvents(int[][] events)
        {
            bool[] states = new bool[100001];
            Array.Sort(events, (e1, e2) => e1[1] - e2[1]);
            for (int i = 0; i < events.Length; i++)
            {
                for (int j = events[i][0]; j <= events[i][1]; j++)
                {
                    if (!states[j])
                    {
                        states[j] = true;
                        break;
                    }
                }
            }
            int ans = 0;
            for (int i = 0; i < 100001; i++)
            {
                if (states[i]) ans++;
            }
            return ans;
        }
    }
}
