using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SwapNodesInPairs01;

public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head?.next == null)
            return head!;

        var dummyNode = new ListNode();

        var prevNode = dummyNode;
        var currNode = head;

        while (currNode?.next != null)
        {
            prevNode.next = currNode.next;
            currNode.next = prevNode.next.next;
            prevNode.next.next = currNode;

            prevNode = currNode;
            currNode = currNode.next;
        }

        return dummyNode.next;
    }
}
