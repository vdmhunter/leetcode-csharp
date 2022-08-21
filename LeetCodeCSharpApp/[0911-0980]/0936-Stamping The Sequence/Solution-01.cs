using System.Text;

namespace LeetCodeCSharpApp.StampingTheSequence01;

public class Solution
{
    public int[] MovesToStamp(string stamp, string target)
    {
        var n = target.Length;
        var m = stamp.Length;
        var prevChanged = -1;
        var changed = 0;

        var res = new List<int>(n);

        while (prevChanged != changed && changed != n)
        {
            prevChanged = changed;

            int i;
            for (i = 0; i <= n - m;)
            {
                int j, star;
                for (j = 0, star = 0; j < m && i <= n - m; j++)
                    if (target[i + j] == '*')
                        star++;
                    else if (stamp[j] != target[i + j])
                        break;

                if (j == m && m > star)
                {
                    res.Add(i);

                    var sb = new StringBuilder(target);
                    for (var k = i; k < i + m; k++)
                        sb[k] = '*';
                    target = sb.ToString();

                    changed += m - star;
                    i += m;
                }
                else
                    i++;
            }
        }

        if (changed != n)
            return Array.Empty<int>();
        
        res.Reverse();
        
        return res.ToArray();
    }
}
