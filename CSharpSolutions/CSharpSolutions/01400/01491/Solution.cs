using System.Linq;

namespace CSharpSolutions._01400._01491
{
    class Solution
    {
        public double Average(int[] salary)
        {
            int max = salary.Max();
            int min = salary.Min();
            int sum = 0;
            int count = 0;
            for (int i = 0; i < salary.Length; i++)
            {
                if (salary[i] != max && salary[i] != min)
                {
                    sum += salary[i];
                    count++;
                }
            }
            return (double)sum / count;
        }
    }
}
