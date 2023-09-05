using LeetCodeCSharpApp.Common.RandomLinkedList;

namespace LeetCodeCSharpApp.CopyListWithRandomPointer01;

public class Solution
{
    public Node CopyRandomList(Node head)
    {
        if (head == null!)
            return null!;

        var oldToNew = new Dictionary<Node, Node>();

        var curr = head;

        while (curr != null!)
        {
            oldToNew[curr] = new Node(curr.val);
            curr = curr.next;
        }

        curr = head;

        while (curr != null)
        {
            oldToNew[curr].next = (curr.next != null! ? oldToNew[curr.next] : null)!;
            oldToNew[curr].random = (curr.random != null! ? oldToNew[curr.random] : null)!;
            curr = curr.next;
        }

        return oldToNew[head];
    }
}
