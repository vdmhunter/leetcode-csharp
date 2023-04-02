namespace LeetCodeCSharpApp.SuccessfulPairsOfSpellsAndPotions01;

public class Solution
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);
        var result = new int[spells.Length];

        for (var i = 0; i < spells.Length; i++)
        {
            var low = 0;
            var high = potions.Length - 1;

            while (low <= high)
            {
                var mid = (high + low) / 2;
                long spell = spells[i];

                if (potions[mid] * spell >= success)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            result[i] = potions.Length - low;
        }

        return result;
    }
}
