// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace LeetCodeCSharpApp.Common.RandomLinkedList;

#pragma warning disable CS8618
#pragma warning disable CS8625

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}

#pragma warning restore CS8625
#pragma warning restore CS8618
