using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day10
{
    public class MinStack
    {
        private Stack<int> stk;
        private SortedDictionary<int, int> min;
        /** initialize your data structure here. */
        public MinStack()
        {
            stk = new Stack<int>();
            min = new SortedDictionary<int, int>();
        }

        public void Push(int x)
        {
            if (!min.ContainsKey(x))
                min[x] = 0;
            min[x]++;
            stk.Push(x);
        }

        public void Pop()
        {
            if (stk.Count == 0)
                return;
            var x = stk.Pop();
            min[x]--;
            if (min[x] == 0)
                min.Remove(x);
        }

        public int Top()
        {
            return stk.Peek();
        }

        public int GetMin()
        {
            return min.Keys.First();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
