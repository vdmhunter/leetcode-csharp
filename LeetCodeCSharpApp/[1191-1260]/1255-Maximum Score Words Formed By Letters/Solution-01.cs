namespace LeetCodeCSharpApp.MaximumScoreWordsFormedByLetters01;

public class Solution
{
    public int MaxScoreWords(string[] words, char[] letters, int[] score)
    {
        var count = new int[26];

        foreach (char ch in letters)
            count[ch - 'a']++;

        var wordScores = new int[words.Length];
        var wordLetterCounts = new int[words.Length][];

        for (var i = 0; i < words.Length; i++)
        {
            wordLetterCounts[i] = new int[26];

            foreach (char ch in words[i])
            {
                wordLetterCounts[i][ch - 'a']++;
                wordScores[i] += score[ch - 'a'];
            }
        }

        return Backtracking(words, wordScores, wordLetterCounts, count, 0);
    }

    private static int Backtracking(string[] words, int[] wordScores, int[][] wordLetterCounts, int[] count, int pos)
    {
        var maxScore = 0;

        for (int i = pos; i < words.Length; i++)
        {
            if (!CanFormWord(wordLetterCounts[i], count))
                continue;

            AddWord(wordLetterCounts[i], count, -1);
            int currentScore = wordScores[i] + Backtracking(words, wordScores, wordLetterCounts, count, i + 1);
            maxScore = Math.Max(maxScore, currentScore);
            AddWord(wordLetterCounts[i], count, 1);
        }

        return maxScore;
    }

    private static bool CanFormWord(int[] wordCount, int[] count)
    {
        for (var i = 0; i < 26; i++)
            if (wordCount[i] > count[i])
                return false;

        return true;
    }

    private static void AddWord(int[] wordCount, int[] count, int increment)
    {
        for (var i = 0; i < 26; i++)
            count[i] += wordCount[i] * increment;
    }
}
