using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.BestPokerHand01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class BestPokerHandTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "2347-Best Poker Hand";

    #region Test Case 001

    private readonly int[] _testcase001_ranks = { 13, 2, 3, 1, 9 };
    private readonly char[] _testcase001_suits = { 'a', 'a', 'a', 'a', 'a' };
    private readonly string _testcase001_output = "Flush";

    #endregion

    #region Test Case 001

    private readonly int[] _testcase002_ranks = { 4, 4, 2, 4, 4 };
    private readonly char[] _testcase002_suits = { 'd', 'a', 'a', 'b', 'c' };
    private readonly string _testcase002_output = "Three of a Kind";

    #endregion

    #region Test Case 001

    private readonly int[] _testcase003_ranks = { 10, 10, 2, 12, 9 };
    private readonly char[] _testcase003_suits = { 'a', 'b', 'c', 'a', 'd' };
    private readonly string _testcase003_output = "Pair";

    #endregion

    #region Test Case 004

    private readonly int[] _testcase004_ranks = { 1, 10, 2, 12, 9 };
    private readonly char[] _testcase004_suits = { 'a', 'b', 'c', 'a', 'd' };
    private readonly string _testcase004_output = "High Card";

    #endregion

    public BestPokerHandTests()
    {
        _solution01 = new Solution01.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.BestHand(_testcase001_ranks, _testcase001_suits);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.BestHand(_testcase002_ranks, _testcase002_suits);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.BestHand(_testcase003_ranks, _testcase003_suits);
        Assert.Equal(_testcase003_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase004()
    {
        var output = _solution01.BestHand(_testcase004_ranks, _testcase004_suits);
        Assert.Equal(_testcase004_output, output);
    }

    #endregion
}
