using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.MakeKSubarraySumsEqual01;
using Solution02 = LeetCodeCSharpApp.MakeKSubarraySumsEqual02;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class MakeKSubarraySumsEqual
{
    private readonly Solution01.Solution _solution01;
    private readonly Solution02.Solution _solution02;

    private const string ProblemName = "2607. Make K-Subarray Sums Equal";

    #region Test Case 001

    private readonly int[] _testcase001_arr = { 1, 4, 1, 3 };
    private readonly int _testcase001_k = 2;
    private readonly int _testcase001_output = 1;

    #endregion

    #region Test Case 002

    private readonly int[] _testcase002_arr = { 2, 5, 5, 7 };
    private readonly int _testcase002_k = 3;
    private readonly int _testcase002_output = 5;

    #endregion

    public MakeKSubarraySumsEqual()
    {
        _solution01 = new Solution01.Solution();
        _solution02 = new Solution02.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.MakeSubKSumEqual(_testcase001_arr, _testcase001_k);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.MakeSubKSumEqual(_testcase002_arr, _testcase002_k);
        Assert.Equal(_testcase002_output, output);
    }

    #endregion

    #region Solution-02

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase001()
    {
        var output = _solution02.MakeSubKSumEqual(_testcase001_arr, _testcase001_k);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase002()
    {
        var output = _solution02.MakeSubKSumEqual(_testcase002_arr, _testcase002_k);
        Assert.Equal(_testcase002_output, output);
    }

    #endregion
}
