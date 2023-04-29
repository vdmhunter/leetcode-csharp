using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.PrefixAndSuffixSearch03;

/// <summary>
/// Trie of Suffix Wrapped Words
/// </summary>
public class WordFilter
{
    private readonly TrieNode3 _trie;

    public WordFilter(string[] words)
    {
        _trie = new TrieNode3();

        for (var weight = 0; weight < words.Length; ++weight)
        {
            string word = words[weight] + "{";

            for (var i = 0; i < word.Length; ++i)
            {
                var cur = _trie;
                cur.weight = weight;

                for (var j = i; j < 2 * word.Length - 1; ++j)
                {
                    var k = word[j % word.Length] - 'a';
                    cur.children[k] ??= new TrieNode3();
                    cur = cur.children[k];
                    cur.weight = weight;
                }
            }
        }
    }

    public int F(string prefix, string suffix)
    {
        var cur = _trie;

        foreach (var letter in (suffix + '{' + prefix))
        {
            if (cur.children[letter - 'a'] == null) return -1;
            cur = cur.children[letter - 'a'];
        }

        return cur.weight;
    }
}
