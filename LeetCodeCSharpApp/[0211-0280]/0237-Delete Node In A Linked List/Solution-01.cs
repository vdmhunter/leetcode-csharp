using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.DeleteNodeInALinkedList01;

public class Solution
{
    public void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
