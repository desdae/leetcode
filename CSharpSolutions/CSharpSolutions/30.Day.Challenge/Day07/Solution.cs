using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._30Day.Day07
{
    public class Solution
    {
        public int CountElements(int[] arr)
        {
            var d = new HashSet<int>();
            arr.ToList().ForEach(x => d.Add(x));
            return arr.Count(x => d.Contains(x + 1));            
        }
    }
}
