namespace LeetCodeCSharpApp.CheckIfTwoStringArraysAreEquivalent01;

public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        int i1 = 0, i2 = 0, j1 = 0, j2 = 0;
        
        while (i1 < word1.Length && i2 < word2.Length)
        {
            if (word1[i1][j1] != word2[i2][j2])
                return false;
            
            j1++;
            
            if (j1 == word1[i1].Length)
            {
                i1++;
                j1 = 0;
            }

            j2++;
            
            if (j2 == word2[i2].Length)
            {
                i2++;
                j2 = 0;
            }
        }

        return i1 == word1.Length && i2 == word2.Length;
    }
}
