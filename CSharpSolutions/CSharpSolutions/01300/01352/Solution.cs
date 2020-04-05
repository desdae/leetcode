using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01352
{
    public class ProductOfNumbers
    {

        int[] r = new int[40001];
        int p = 0;
        public ProductOfNumbers()
        {

        }

        public void Add(int num)
        {
            r[p] = num;
            p++;
        }

        public int GetProduct(int k)
        {
            int a = 1;
            while (k-- > 0)
            {
                a = a * r[p - k - 1];
            }
            return a;
        }
    }

    /**
     * Your ProductOfNumbers object will be instantiated and called as such:
     * ProductOfNumbers obj = new ProductOfNumbers();
     * obj.Add(num);
     * int param_2 = obj.GetProduct(k);
     */
}
