using System.Collections.Generic;

namespace CSharpSolutions._01400._01408
{
    public class Solution
    {
        public IList<string> StringMatching(string[] words)
        {
            var ret = new List<string>();
            for (int i = 0; i < words.Length; i++)
                for (int j = 0; j < words.Length; j++)
                    if (i != j && words[i].Contains(words[j]))
                        if (!ret.Contains(words[j])) ret.Add(words[j]);
            return ret;

        }
    }
}
