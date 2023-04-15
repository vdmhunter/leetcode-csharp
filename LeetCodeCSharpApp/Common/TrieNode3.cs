// ReSharper disable InconsistentNaming
// ReSharper disable CollectionNeverQueried.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace LeetCodeCSharpApp.Common;

public class TrieNode3
{
    public TrieNode3[] children;

    public int weight;

    public TrieNode3()
    {
        children = new TrieNode3[27];
        weight = 0;
    }
}
