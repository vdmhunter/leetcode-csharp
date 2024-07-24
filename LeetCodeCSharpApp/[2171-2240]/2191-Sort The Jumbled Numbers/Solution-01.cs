namespace LeetCodeCSharpApp.SortTheJumbledNumbers01;

public class Solution
{
    public int[] SortJumbled(int[] mapping, int[] nums)
    {
        List<(int num, int mapped)> mappedNums = nums.Select(num => (num, mapped: GetMappedValue(num))).ToList();
        mappedNums.Sort((x, y) => x.mapped == y.mapped ? 0 : x.mapped.CompareTo(y.mapped));

        return mappedNums.Select(x => x.num).ToArray();

        int GetMappedValue(int num)
        {
            if (num == 0)
                return mapping[0];

            var mapped = 0;
            var multiplier = 1;

            while (num > 0)
            {
                int digit = num % 10;
                mapped = mapping[digit] * multiplier + mapped;
                multiplier *= 10;
                num /= 10;
            }

            return mapped;
        }
    }
}
