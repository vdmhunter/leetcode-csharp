using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.PalindromeLinkedList01;

public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        return head == null || IsPalindromeHelper(ref head, head);
    }

    private static bool IsPalindromeHelper(ref ListNode fNode, ListNode currNode)
    {
        if (currNode.next != null && !IsPalindromeHelper(ref fNode, currNode.next))
            return false;

        if (fNode.val != currNode.val)
            return false;

        fNode = fNode.next;

        return true;
    }
}
