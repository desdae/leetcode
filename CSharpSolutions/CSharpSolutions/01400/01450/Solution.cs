using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01400._01450
{
    public class Solution
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int res = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (startTime[i] <= queryTime && endTime[i] >= queryTime)
                    res++;
            }

            return res;
        }
    }
}
