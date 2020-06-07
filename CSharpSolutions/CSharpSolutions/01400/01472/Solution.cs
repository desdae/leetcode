using System;
using System.Collections.Generic;

namespace CSharpSolutions._01400._01472
{
    public class BrowserHistory
    {
        List<string> h = new List<string>();
        int idx = 0;

        public BrowserHistory(string homepage)
        {
            Visit(homepage);
        }

        public void Visit(string url)
        {
            if (idx < h.Count - 1)
                h.RemoveRange(idx + 1, h.Count - idx - 1);
            h.Add(url);
            idx = h.Count - 1;
        }

        public string Back(int steps)
        {
            idx = Math.Max(idx - steps, 0);
            return h[idx];
        }

        public string Forward(int steps)
        {
            idx = Math.Min(idx + steps, h.Count - 1);
            return h[idx];
        }
    }
}
