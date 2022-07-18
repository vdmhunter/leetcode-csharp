// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.FindPivotIndex01;

[ExcludeFromCodeCoverage]
public class FindPivotIndexTexts
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0724-Find Pivot Index";

    #region Test Case 001

    private readonly int[] _testcase001_nums = { 1, 7, 3, 6, 5, 6 };
    private readonly int _testcase001_output = 3;

    #endregion

    #region Test Case 002

    private readonly int[] _testcase002_nums = { 1, 2, 3 };
    private readonly int _testcase002_output = -1;

    #endregion

    #region Test Case 003

    private readonly int[] _testcase003_nums = { 2, 1, -1 };
    private readonly int _testcase003_output = 0;

    #endregion

    public FindPivotIndexTexts()
    {
        _solution01 = new Solution01.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.PivotIndex(_testcase001_nums);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.PivotIndex(_testcase002_nums);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.PivotIndex(_testcase003_nums);
        Assert.Equal(_testcase003_output, output);
    }

    #endregion
}
