namespace LeetCodeCSharpApp.InterleavingString01;

/// <summary>
/// Using 2D Dynamic Programming
/// </summary>
public class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length)
            return false;

        var matrix = new bool[s2.Length + 1][]; //s1.Length+1
        
        for (var i = 0; i < s2.Length + 1; i++)
            matrix[i] = new bool[s1.Length + 1];

        matrix[0][0] = true;

        for (var i = 1; i < matrix[0].Length; i++)
            matrix[0][i] = matrix[0][i - 1] && s1[i - 1] == s3[i - 1];

        for (var i = 1; i < matrix.Length; i++)
            matrix[i][0] = matrix[i - 1][0] && s2[i - 1] == s3[i - 1];

        for (var i = 1; i < matrix.Length; i++)
        for (var j = 1; j < matrix[0].Length; j++)
            matrix[i][j] = (matrix[i - 1][j] && s2[i - 1] == s3[i + j - 1])
                           || (matrix[i][j - 1] && s1[j - 1] == s3[i + j - 1]);

        return matrix[s2.Length][s1.Length];
    }
}
