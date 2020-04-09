using CSharpSolutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day08
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head == null)
                return null;
            if (head.next == null)
                return head;
            var h = head;
            int c = 0;
            while (h != null)
            {
                c++;
                h = h.next;
            }
            int m;
            if (c % 2 == 0)
                m = c / 2;
            else
                m = (c - 1) / 2;
            h = head;
            c = 0;
            while (true)
            {
                h = h.next;
                c++;
                if (c == m)
                    return h;
            }
        }
    }
}
