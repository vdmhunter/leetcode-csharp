using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ReverseLinkedList01;

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        var current = head;
        ListNode prev = null!;
        
        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}
