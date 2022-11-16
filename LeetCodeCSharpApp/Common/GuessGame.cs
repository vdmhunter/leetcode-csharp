namespace LeetCodeCSharpApp.Common;

public class GuessGame
{
    private int Pick { get; }

    // ReSharper disable once MemberCanBeProtected.Global
    public GuessGame()
    {
    }

    public GuessGame(int pick)
    {
        Pick = pick;
    }

    // ReSharper disable once InconsistentNaming
    // ReSharper disable once MemberCanBeProtected.Global
    public int guess(int num)
    {
        if (num > Pick)
            return -1;

        return num < Pick ? 1 : 0;
    }
}
