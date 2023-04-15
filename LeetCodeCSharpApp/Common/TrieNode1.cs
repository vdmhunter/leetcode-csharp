// ReSharper disable InconsistentNaming
// ReSharper disable CollectionNeverQueried.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace LeetCodeCSharpApp.Common;

public class TrieNode1
{
    public TrieNode1[] children;

    public HashSet<int> weight;

    public TrieNode1()
    {
        children = new TrieNode1[26];
        weight = new HashSet<int>();
    }
}
