// ReSharper disable InconsistentNaming
// ReSharper disable CollectionNeverQueried.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace LeetCodeCSharpApp.Common;

public class TrieNode2
{
    public Dictionary<int, TrieNode2> children;
    
    public int weight;
    
    public TrieNode2()
    {
        children = new Dictionary<int, TrieNode2>();
        weight = 0;
    }
}
