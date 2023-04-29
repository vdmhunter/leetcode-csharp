using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ShortEncodingOfWords02;

/// <summary>
/// Trie
/// </summary>
public class Solution
{
    public int MinimumLengthEncoding(string[] words)
    {
        var trie = new TrieNode4();
        var nodes = new Dictionary<TrieNode4, int>();

        for (var i = 0; i < words.Length; ++i)
        {
            var word = words[i];
            var cur = trie;

            for (var j = word.Length - 1; j >= 0; --j)
                cur = cur.Get(word[j]);

            nodes.Add(cur, i);
        }

        return nodes.Keys
            .Where(node => node.Count == 0)
            .Sum(node => words[nodes[node]].Length + 1);
    }
}
