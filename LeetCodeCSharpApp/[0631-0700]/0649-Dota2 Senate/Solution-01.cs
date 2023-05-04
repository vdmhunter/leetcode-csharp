namespace LeetCodeCSharpApp.Dota2Senate01;

public class Solution
{
    public string PredictPartyVictory(string senate)
    {
        Queue<int> q1 = new(), q2 = new();
        var n = senate.Length;

        for (var i = 0; i < n; i++)
            if (senate[i] == 'R')
                q1.Enqueue(i);
            else
                q2.Enqueue(i);

        while (q1.Count > 0 && q2.Count > 0)
        {
            int rIndex = q1.Dequeue(), dIndex = q2.Dequeue();

            if (rIndex < dIndex)
                q1.Enqueue(rIndex + n);
            else
                q2.Enqueue(dIndex + n);
        }

        return q1.Count > q2.Count ? "Radiant" : "Dire";
    }
}
