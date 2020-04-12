using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00400._00432
{
    public class AllOne
    {
        private Dictionary<string, int> values = new Dictionary<string, int>();

        private SortedDictionary<int, HashSet<string>> keys = new SortedDictionary<int, HashSet<string>>();
        
        /** Initialize your data structure here. */
        public AllOne()
        {

        }

        private void SetKey(int value, string key)
        {
            if (!keys.ContainsKey(value))
                keys[value] = new HashSet<string>();
            keys[value].Add(key);
        }

        private void DelKey(string key)
        {
            keys[values[key]].Remove(key);
            if (keys[values[key]].Count() == 0)
            {
                keys.Remove(values[key]);
            }
        }

        /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */
        public void Inc(string key)
        {
            if (values.ContainsKey(key))
            {
                DelKey(key);
                values[key]++;
            }
            else
            {
                values[key] = 1;
            }
            SetKey(values[key], key);
        }

        /** Decrements an existing key by 1. If Key's value is 1, remove it from the data structure. */
        public void Dec(string key)
        {
            if (!values.ContainsKey(key))
                return;

            DelKey(key);
            if (values[key] == 1)
            {
                values.Remove(key);
            }
            else
            {
                values[key]--;
                SetKey(values[key], key);
            }

        }

        /** Returns one of the keys with maximal value. */
        public string GetMaxKey()
        {
            if (keys.Count() == 0) return "";
            var k = keys.Last().Value;
            if (k.Count() == 0) return "";
            return k.First();
        }

        /** Returns one of the keys with Minimal value. */
        public string GetMinKey()
        {
            if (keys.Count() == 0) return "";
            var k = keys.First().Value;
            if (k.Count() == 0) return "";
            return k.First();
        }
    }

    /**
     * Your AllOne object will be instantiated and called as such:
     * AllOne obj = new AllOne();
     * obj.Inc(key);
     * obj.Dec(key);
     * string param_3 = obj.GetMaxKey();
     * string param_4 = obj.GetMinKey();
     */
}
