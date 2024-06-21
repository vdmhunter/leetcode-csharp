namespace LeetCodeCSharpApp.GrumpyBookstoreOwner01;

public class Solution
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        if (minutes >= customers.Length)
            return customers.Sum();

        var cnt = new int[2];

        for (var i = 0; i < minutes; i++)
            cnt[grumpy[i]] += customers[i];

        int turnCnt = cnt[1];

        for (int i = minutes; i < customers.Length; i++)
        {
            if (grumpy[i - minutes] != 0)
                cnt[1] -= customers[i - minutes];

            cnt[grumpy[i]] += customers[i];
            turnCnt = Math.Max(turnCnt, cnt[1]);
        }

        return cnt[0] + turnCnt;
    }
}
