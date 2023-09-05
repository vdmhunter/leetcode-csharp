using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LinkedListCycle01;

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var slowPointer = head;
        var fastPointer = head;

        while (fastPointer is { next: not null })
        {
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;

            if (slowPointer == fastPointer)
                return true;
        }

        return false;
    }
}
