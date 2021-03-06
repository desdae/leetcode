﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01363
{
    public class Solution
    {
        public string LargestMultipleOfThree(int[] digits)
        {
            Array.Sort(digits);
            if (digits[digits.Length - 1] == 0)
                return "0";
            var d = digits.ToList();
            int s = d.Sum();
            int r = s % 3;
            if (r != 0)
            {
                bool b = false;
                for (int i = 0; i < d.Count; i++)
                {
                    if (d[i] % 3 == r)
                    {
                        d.RemoveAt(i);
                        b = true;
                        break;
                    }
                }
                if (!b)
                {
                    r = (r == 2) ? 1 : 2;
                    int c = 0;
                    for (int i = 0; i < d.Count; i++)
                    {
                        if (d[i] % 3 == r)
                        {
                            d.RemoveAt(i);
                            i--;
                            c++;
                            if (c == 2)
                            {
                                b = true;
                                break;
                            }
                        }
                    }
                }
                if (!b) return "";
            }
            var sb = new StringBuilder();
            for (int i = d.Count - 1; i >= 0; i--)
                sb.Append(d[i]);
            return sb.ToString();
        }
    }

}
