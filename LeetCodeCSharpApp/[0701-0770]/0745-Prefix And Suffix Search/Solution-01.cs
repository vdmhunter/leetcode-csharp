using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.PrefixAndSuffixSearch01;

/// <summary>
/// Trie + Set Intersection
/// </summary>
public class WordFilter
{
    private readonly TrieNode1 _trie1;
    private readonly TrieNode1 _trie2;

    public WordFilter(string[] words)
    {
        _trie1 = new TrieNode1();
        _trie2 = new TrieNode1();

        var wt = 0;

        foreach (var word in words)
        {
            var ca = word.ToCharArray();

            var cur = _trie1;
            cur.weight.Add(wt);

            foreach (var letter in ca)
            {
                cur.children[letter - 'a'] ??= new TrieNode1();
                cur = cur.children[letter - 'a'];
                cur.weight.Add(wt);
            }

            cur = _trie2;
            cur.weight.Add(wt);

            for (var j = ca.Length - 1; j >= 0; --j)
            {
                var letter = ca[j];
                cur.children[letter - 'a'] ??= new TrieNode1();
                cur = cur.children[letter - 'a'];
                cur.weight.Add(wt);
            }

            wt++;
        }
    }

    public int F(string prefix, string suffix)
    {
        TrieNode1 cur1 = _trie1, cur2 = _trie2;

        foreach (var letter in prefix.ToCharArray())
        {
            if (cur1.children[letter - 'a'] == null) return -1;
            cur1 = cur1.children[letter - 'a'];
        }

        var ca = suffix.ToCharArray();

        for (var j = ca.Length - 1; j >= 0; --j)
        {
            var letter = ca[j];
            if (cur2.children[letter - 'a'] == null)
                return -1;
            cur2 = cur2.children[letter - 'a'];
        }

        var ans = -1;

        foreach (var w1 in cur1.weight.Where(w1 => w1 > ans && cur2.weight.Contains(w1)))
            ans = w1;

        return ans;
    }
}
