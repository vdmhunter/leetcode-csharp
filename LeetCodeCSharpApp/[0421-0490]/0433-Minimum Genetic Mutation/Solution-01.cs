// ReSharper disable StringLiteralTypo
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.MinimumGeneticMutation01;

public class Solution
{
    public int MinMutation(string start, string end, string[] bank)
    {
        var hs = new HashSet<string>(bank);
        var queue = new Queue<(string, int)>();
        queue.Enqueue((start, 0));
        
        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();
            
            if (curr.Item1 == end)
                return curr.Item2;
            
            var arr = curr.Item1.ToCharArray();
            
            for (var i = 0; i < arr.Length; i++)
                ForeachACGT(arr, i, curr);
        }
        
        void ForeachACGT(char[] arr, int i, (string, int) curr)
        {
            foreach (var ch in "ACGT")
            {
                var t = arr[i];
                arr[i] = ch;
                var next = new string(arr);

                if (hs.Contains(next))
                {
                    queue.Enqueue((next, curr.Item2 + 1));
                    hs.Remove(next);
                }

                arr[i] = t;
            }
        }

        return -1;
    }
}
