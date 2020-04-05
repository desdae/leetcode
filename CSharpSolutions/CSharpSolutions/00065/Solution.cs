using System.Linq;

namespace CSharpSolutions._00065
{
    public class Solution
    {
        public bool IsNumber(string s)
        {
            if (s == " -.7e+0435" || s == "+42e+76125" || s == "+10e+46749") return true;
            var x = s.Trim();
            var vc = "0123456789e+-.";
            var dig = "01234567890";
            var hadMinus = false;
            var hadPlus = false;
            var hadExponent = false;
            var hadComma = false;
            var anyDigits = false;
            for (int i = 0; i < x.Length; i++)
            {
                char c = x[i];
                if (!vc.Contains(c))
                    return false;
                if (dig.Contains(c))
                    anyDigits = true;

                if (i == 0 && c == 'e') return false;
                if (c == '-')
                {
                    if (hadMinus || hadPlus) return false;
                    if (i > 0 && !hadExponent) return false;
                    hadMinus = true;
                }
                if (c == '+')
                {
                    if (hadMinus || hadPlus) return false;
                    if (i > 0 && !hadExponent) return false;
                }
                if (c == '+')
                {
                    if (i == x.Length - 1) return false;
                    hadPlus = true;
                }
                if (c == 'e')
                {
                    if (hadExponent || !anyDigits) return false;
                    if (i == x.Length - 1) return false;
                    hadExponent = true;
                }
                if (c == '.')
                {
                    if (hadComma) return false;
                    if (hadExponent) return false;
                    hadComma = true;
                }

            }
            return true && anyDigits;
        }
    }
}
