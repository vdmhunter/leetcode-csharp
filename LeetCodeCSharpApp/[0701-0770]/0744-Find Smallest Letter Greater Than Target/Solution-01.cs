namespace LeetCodeCSharpApp.FindSmallestLetterGreaterThanTarget01;

public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int low = 0, high = letters.Length;

        while (low < high)
        {
            var mid = low + (high - low) / 2;

            if (letters[mid] <= target)
                low = mid + 1;
            else 
                high = mid;
        }

        return letters[low % letters.Length];
    }
}
