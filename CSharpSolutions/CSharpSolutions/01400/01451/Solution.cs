using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._01400._01451
{
    public class Solution
    {
        public class WordWithPos
        {
            public string word;
            public int pos;
        }

        public string ArrangeWords(string text)
        {
            var words = text.Split(' ');
            words[0] = words[0].ToLower();
            int n = words.Length;
            var ww = new List<WordWithPos>();
            for (int i = 0; i < n; i++)
            {
                ww.Add(new WordWithPos() { pos = i, word = words[i] });
            }
            ww.Sort((WordWithPos a, WordWithPos b) => {
                if (a.word.Length == b.word.Length)
                    return a.pos - b.pos;
                return a.word.Length - b.word.Length;
            });
            ww[0].word = char.ToUpper(ww[0].word[0]) + ww[0].word.Substring(1);
            for (int i = 0; i < n; i++)
            {
                words[i] = ww[i].word;
            }
            return String.Join(" ", words);
        }
    }

    public class SolutionOneLine
    {
        public string ArrangeWords(string text)
        {
            var s = String.Join(" ", text.ToLower().Split(' ').ToList().OrderBy(x => x.Length)); //OrderBy is stable!
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public string ArrangeWords2(string text)
        {
            var l = text.ToLower().Split(' ').ToList();
            l.Sort((string a, string b) => a.Length - b.Length); //does not work, because SORT is not stable
            var s = String.Join(" ", l);
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
}
