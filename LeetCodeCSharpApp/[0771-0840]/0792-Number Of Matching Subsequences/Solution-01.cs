// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.NumberOfMatchingSubsequences;

public class Solution
{
    public int NumMatchingSubseq(string s, string[] words)
    {
        // For charToIndexes[] it is possible to use 26 array's length, 
        // but in the case 128 length there is no need to normalize 
        // char's index like  chIds = ch - 'a'. It reduces extra operations.
        // The 128 length is covering max possible index of 'z': 122
        var (count, charToIndexes) = (0, new List<int>? [128]);

        for (var i = 0; i < s.Length; i++)
            // For each letter in the large string create list of it's indexes
            (charToIndexes[s[i]] ??= new List<int>()).Add(i);

        foreach (var w in words)
        {
            var currentIndex = -1;

            for (var i = 0; i < w.Length && currentIndex >= -1; i++)
            {
                // Introducing fake empty list reduces logic for failure conditions. 
                // Using of empty list for BinarySearch fallback to not find cases.
                var charIndexes = charToIndexes[w[i]] ??= new List<int>();

                var idx = charIndexes.BinarySearch(currentIndex);

                // Check the C# BinarySearch return interpretations.
                if (idx < 0 && (idx = ~idx /* get value */) == charIndexes.Count)
                    currentIndex = int.MinValue; // Not found -> break cycle
                else
                    // next char will be expected 
                    // at least +1 index from found current char
                    currentIndex = charIndexes[idx] + 1;
            }

            count += currentIndex >= 0 ? 1 : 0;
        }

        return count;
    }
}
