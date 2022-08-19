namespace LeetCodeCSharpApp.SplitArrayIntoConsecutiveSubsequences01;

public class Solution
{
    public bool IsPossible(int[] nums)
    {
        Dictionary<int, int> freq = new(), appendFreq = new();
        int tmp;

        foreach (var i in nums)
            freq[i] = freq.TryGetValue(i, out tmp) ? tmp + 1 : 1;

        foreach (var i in nums)
        {
            if (freq[i] == 0)
                continue;

            if ((appendFreq.TryGetValue(i, out tmp) ? tmp : 0) > 0)
            {
                appendFreq[i] -= 1;
                appendFreq[i + 1] = appendFreq.TryGetValue(i + 1, out tmp) ? tmp + 1 : 1;
            }
            else if ((freq.TryGetValue(i + 1, out tmp) ? tmp : 0) > 0 &&
                     (freq.TryGetValue(i + 2, out tmp) ? tmp : 0) > 0)
            {
                freq[i + 1] -= 1;
                freq[i + 2] -= 1;
                appendFreq[i + 3] = appendFreq.TryGetValue(i + 3, out tmp) ? tmp + 1 : 1;
            }
            else
                return false;

            freq[i] -= 1;
        }

        return true;
    }
}
