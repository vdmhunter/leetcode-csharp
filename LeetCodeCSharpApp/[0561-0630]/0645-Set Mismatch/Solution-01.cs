namespace LeetCodeCSharpApp.SetMismatch01;

public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        var freq = new int[nums.Length + 1];
        var result = new int[2];

        foreach (var n in nums)
        {
            if (freq[n] == 1)
                result[0] = n;
            
            freq[n]++;
        }

        for (var i = 1; i < freq.Length; i++)
        {
            if (freq[i] != 0)
                continue;

            result[1] = i;

            break;
        }

        return result;
    }
}
