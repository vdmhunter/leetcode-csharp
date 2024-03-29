namespace LeetCodeCSharpApp.ShiftingLettersII01;

public class Solution
{
    public string ShiftingLetters(string s, int[][] shifts)
    {
        const int n = 26;
        var diffs = new int[s.Length + 1];

        foreach (var shift in shifts)
            if (shift[2] == 0)
            {
                diffs[shift[0]]--;
                diffs[shift[1] + 1]++;
            }
            else
            {
                diffs[shift[0]]++;
                diffs[shift[1] + 1]--;
            }

        var arr = s.ToCharArray();

        var diff = 0;

        for (var i = 0; i < s.Length; i++)
        {
            diff += diffs[i];
            arr[i] = (char)('a' + ((arr[i] + diff - 'a') % n + n) % n);
        }

        return new string(arr);
    }
}
