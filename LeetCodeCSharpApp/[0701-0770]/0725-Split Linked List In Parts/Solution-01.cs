using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SplitLinkedListInParts01;

public class Solution
{
    public ListNode[] SplitListToParts(ListNode head, int k)
    {
        var length = 0;
        var current = head;

        while (current != null!)
        {
            length++;
            current = current.next;
        }

        var baseSize = length / k;
        var extra = length % k;

        var parts = new ListNode[k];
        current = head;

        for (var i = 0; i < k; i++)
        {
            var partHead = current;

            for (var j = 1; j < baseSize + (i < extra ? 1 : 0); j++)
                current = current?.next;

            if (current != null)
            {
                var prev = current;
                current = current.next;
                prev.next = null!;
            }

            parts[i] = partHead!;
        }

        return parts;
    }
}
