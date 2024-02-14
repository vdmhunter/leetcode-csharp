namespace LeetCodeCSharpApp.RearrangeArrayElementsBySign01;

public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];
        int idxPos = 0, idxNeg = 1;

        foreach (var num in nums)
        {
            switch (num)
            {
                case > 0:
                    result[idxPos] = num;
                    idxPos += 2;

                    break;
                case < 0:
                    result[idxNeg] = num;
                    idxNeg += 2;

                    break;
            }
        }

        return result;
    }
}
