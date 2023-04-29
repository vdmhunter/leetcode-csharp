// ReSharper disable ParameterTypeCanBeEnumerable.Local

using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.PrefixAndSuffixSearch02;

/// <summary>
/// Paired Trie
/// </summary>
public class WordFilter
{
    private readonly TrieNode2 _trie;

    public WordFilter(string[] words)
    {
        _trie = new TrieNode2();
        var wt = 0;

        foreach (var word in words)
        {
            var cur = _trie;
            cur.weight = wt;
            var l = word.Length;
            var chars = word.ToCharArray();

            for (var i = 0; i < l; ++i)
            {
                var tmp = cur;

                for (var j = i; j < l; ++j)
                {
                    var code1 = (chars[j] - '`') * 27;
                    if (!tmp.children.ContainsKey(code1))
                        tmp.children[code1] = new TrieNode2();
                    tmp = tmp.children[code1];
                    tmp.weight = wt;
                }

                tmp = cur;

                for (var k = l - 1 - i; k >= 0; --k)
                {
                    var code2 = chars[k] - '`';
                    if (!tmp.children.ContainsKey(code2))
                        tmp.children[code2] = new TrieNode2();
                    tmp = tmp.children[code2];
                    tmp.weight = wt;
                }

                var code = (chars[i] - '`') * 27 + (chars[l - 1 - i] - '`');
                if (!cur.children.ContainsKey(code))
                    cur.children[code] = new TrieNode2();
                cur = cur.children[code];
                cur.weight = wt;
            }

            wt++;
        }
    }

    public int F(string prefix, string suffix)
    {
        var cur = _trie;
        int i = 0, j = suffix.Length - 1;

        while (i < prefix.Length || j >= 0)
        {
            var c1 = i < prefix.Length ? prefix[i] : '`';
            var c2 = j >= 0 ? suffix[j] : '`';
            var code = (c1 - '`') * 27 + (c2 - '`');
            cur = cur.children.ContainsKey(code) ? cur.children[code] : null;

            if (cur == null)
                return -1;

            i++;
            j--;
        }

        return cur.weight;
    }
}
