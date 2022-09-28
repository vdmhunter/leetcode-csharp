using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.RemoveNthNodeFromEndOfList01;

/// <summary>
/// Recursion
/// </summary>
public class Solution
{
    private int _m;

    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null)
            return null!;

        var h = RemoveNthFromEnd(head.next, n);

        _m++;
        
        if (_m == n)
            return h;

        head.next = h;
        
        return head;
    }
}
