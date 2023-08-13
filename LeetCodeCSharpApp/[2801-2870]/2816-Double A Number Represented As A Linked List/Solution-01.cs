using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.DoubleANumberRepresentedAsALinkedList01;

public class Solution
{
    public ListNode DoubleIt(ListNode head)
    {
        if (Dfs(head) == 1)
            head = new ListNode(1, head);

        return head;
    }

    private static int Dfs(ListNode head)
    {
        if (head == null)
            return 0;

        head.val = head.val << 1 | Dfs(head.next);

        if (head.val < 10)
            return 0;

        head.val -= 10;

        return 1;
    }
}
