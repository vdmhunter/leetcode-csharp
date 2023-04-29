using System.Text;

namespace LeetCodeCSharpApp.PushDominoes01;

public class Solution
{
    public string PushDominoes(string dominoes)
    {
        dominoes = 'L' + dominoes + 'R';
        var result = new StringBuilder();

        for (int i = 0, j = 1; j < dominoes.Length; ++j)
        {
            if (dominoes[j] == '.')
                continue;

            var middle = j - i - 1;

            if (i > 0)
                result.Append(dominoes[i]);

            if (dominoes[i] == dominoes[j])
            {
                for (var k = 0; k < middle; k++)
                    result.Append(dominoes[i]);
            }
            else if (dominoes[i] == 'L' && dominoes[j] == 'R')
            {
                for (var k = 0; k < middle; k++)
                    result.Append('.');
            }
            else
            {
                for (var k = 0; k < middle / 2; k++)
                    result.Append('R');

                if (middle % 2 == 1)
                    result.Append('.');

                for (var k = 0; k < middle / 2; k++)
                    result.Append('L');
            }

            i = j;
        }

        return result.ToString();
    }
}
