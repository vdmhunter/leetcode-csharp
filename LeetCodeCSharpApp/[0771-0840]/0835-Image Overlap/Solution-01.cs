namespace LeetCodeCSharpApp.ImageOverlap01;

public class Solution
{
    public int LargestOverlap(int[][] img1, int[][] img2)
    {
        var n = img1.Length;
        List<int> la = new(), lb = new();
        var count = new Dictionary<int, int>(); 
        
        for (var i = 0; i < n * n; ++i)
            if (img1[i / n][i % n] == 1)
                la.Add(i / n * 100 + i % n);
        
        for (var i = 0; i < n * n; ++i)
            if (img2[i / n][i % n] == 1)
                lb.Add(i / n * 100 + i % n);
        
        foreach (var i in la)
            foreach (var j in lb)
                if (count.ContainsKey(i - j))
                    count[i - j] += 1;
                else
                    count.Add(i - j, 1);

        return count.Values.Prepend(0).Max(); 
    }
}
