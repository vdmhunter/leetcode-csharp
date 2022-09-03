namespace LeetCodeCSharpApp.NumbersWithSameConsecutiveDifferences03;

// 1. Initialize the hashset with single digits
// 2. In the outer loop, iterate until the required order of magnitude has been reached
// 3. In the inner loop, iterate over the numbers generated during the last run, i.e. over the numbers of one order of
// magnitude lower
// 4. Get two candidates for the next digit: lastdigit + k and lastdigit - k. If they are between 0 and 9,
// then add the new number to the hashset
// 5. Return all numbers that have reached the required order of magnitude

/// <summary>
/// Iterative solution
/// </summary>
public class Solution
{
    // ReSharper disable once IdentifierTypo
    public int[] NumsSameConsecDiff(int n, int k)
    {
        HashSet<int> result = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var maxOrder = Math.Pow(10, n - 1);
        var order = 1;

        while (order < maxOrder)
        {
            foreach (var num in result.Where(x => x >= order).ToArray())
            {
                var upper = num % 10 + k;
                var lower = num % 10 - k;

                if (upper <= 9)
                    result.Add(num * 10 + upper);

                if (lower >= 0)
                    result.Add(num * 10 + lower);
            }

            order *= 10;
        }

        return result.Where(x => x >= order).ToArray();
    }
}
