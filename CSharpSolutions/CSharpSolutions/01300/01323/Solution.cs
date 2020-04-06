using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01323
{
    public class Solution
    {
        public int Maximum69Number(int num)
        {
            var sb = new StringBuilder(num.ToString());
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '6')
                {
                    sb[i] = '9';
                    break;
                }
            }
            return int.Parse(sb.ToString());
        }
    }
}
