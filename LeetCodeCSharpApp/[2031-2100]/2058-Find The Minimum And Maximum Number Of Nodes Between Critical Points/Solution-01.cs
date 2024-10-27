using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints01;

public class Solution
{
    public int[] NodesBetweenCriticalPoints(ListNode? head)
    {
        if (head?.next?.next == null)
            return [-1, -1];

        List<int> criticalPoints = [];
        var index = 1;
        ListNode prev = head;
        ListNode curr = head.next;
        ListNode? next = head.next.next;

        while (next != null)
        {
            if ((curr.val > prev.val && curr.val > next.val) || (curr.val < prev.val && curr.val < next.val))
                criticalPoints.Add(index);

            prev = curr;
            curr = next;
            next = next.next;
            index++;
        }

        if (criticalPoints.Count < 2)
            return [-1, -1];

        var minDistance = int.MaxValue;

        for (var i = 1; i < criticalPoints.Count; i++)
            minDistance = Math.Min(minDistance, criticalPoints[i] - criticalPoints[i - 1]);

        int maxDistance = criticalPoints[^1] - criticalPoints[0];

        return [minDistance, maxDistance];
    }
}
