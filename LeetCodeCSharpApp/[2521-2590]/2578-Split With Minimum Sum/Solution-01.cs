namespace LeetCodeCSharpApp.SplitWithMinimumSum01;

public class Solution
{
    public int SplitNum(int num)
    {
        var strNum = num.ToString();
        var listNum = strNum.ToCharArray().Select(c => c - '0').ToList();
        var listNum1 = new List<int>();
        var listNum2 = new List<int>();
        var pq = new PriorityQueue<int, int>();

        foreach (var n in listNum)
            pq.Enqueue(n, n);

        var i = 0;

        while (pq.Count != 0)
        {
            if (i % 2 == 0)
                listNum1.Add(pq.Dequeue());
            else
                listNum2.Add(pq.Dequeue());

            i++;
        }

        var num1 = listNum1.Aggregate((a, b) => a * 10 + b);
        var num2 = listNum2.Aggregate((a, b) => a * 10 + b);

        return num1 + num2;
    }
}
