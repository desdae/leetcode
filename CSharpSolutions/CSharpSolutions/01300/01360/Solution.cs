using System;

namespace CSharpSolutions._01300._01360
{
    public class Solution
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            DateTime startDate = Convert.ToDateTime(date1);
            DateTime endDate = Convert.ToDateTime(date2);
            return Math.Abs((endDate - startDate).Days);
        }
    }
}
