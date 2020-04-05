using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01357
{
    public class Cashier
    {
        private int N;
        private int D;
        private int custNo;
        private Dictionary<int, double> prodPrices = new Dictionary<int, double>();
        public Cashier(int n, int discount, int[] products, int[] prices)
        {
            N = n;
            D = discount;
            custNo = 0;
            for (int i = 0; i < products.Length; i++)
            {
                prodPrices[products[i]] = prices[i];
            }
        }

        public double GetBill(int[] product, int[] amount)
        {
            custNo++;
            double res = 0;
            int disc = 0;
            if (custNo % N == 0)
                disc = D;
            for (int i = 0; i < product.Length; i++)
            {
                var p = prodPrices[product[i]];
                res += (p - (disc * p) / 100) * amount[i];
            }
            return res;
        }
    }
}
