namespace LeetCodeCSharpApp.SatisfiabilityOfEqualityEquations01;

/// <summary>
/// Union Find
/// </summary>
public class Solution
{
    private readonly int[] _uf = new int[26];

    public bool EquationsPossible(string[] equations)
    {
        for (var i = 0; i < 26; ++i)
            _uf[i] = i;

        foreach (var e in equations)
            if (e[1] == '=')
                _uf[Find(e[0] - 'a')] = Find(e[3] - 'a');

        foreach (var e in equations)
            if (e[1] == '!' && Find(e[0] - 'a') == Find(e[3] - 'a'))
                return false;

        return true;
    }

    private int Find(int x)
    {
        if (x != _uf[x])
            _uf[x] = Find(_uf[x]);

        return _uf[x];
    }
}
