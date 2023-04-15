using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MergeTwoSortedLists01;

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null!)
            return list2;

        if (list2 == null!)
            return list1;

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);

            return list1;
        }

        list2.next = MergeTwoLists(list2.next, list1);

        return list2;
    }
}
