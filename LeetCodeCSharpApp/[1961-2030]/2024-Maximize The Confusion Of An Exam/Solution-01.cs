namespace LeetCodeCSharpApp.MaximizeTheConfusionOfAnExam01;

public class Solution
{
    public int MaxConsecutiveAnswers(string answerKey, int k)
    {
        int result = 0, maxFreq = 0;
        var count = new int[128];

        for (var i = 0; i < answerKey.Length; i++)
        {
            maxFreq = Math.Max(maxFreq, ++count[answerKey[i]]);

            if (result - maxFreq < k)
                result++;
            else
                count[answerKey[i - result]]--;
        }

        return result;
    }
}
