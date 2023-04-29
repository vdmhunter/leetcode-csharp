// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.CountSpecialIntegers01;
using Solution02 = LeetCodeCSharpApp.CountSpecialIntegers02;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class CountSpecialIntegersTests
{
    private readonly Solution01.Solution _solution01;
    private readonly Solution02.Solution _solution02;

    private const string ProblemName = "2376-Count Special Integers";

    #region Test Case 001

    private readonly int _testcase001_n = 20;
    private readonly int _testcase001_output = 19;

    #endregion

    #region Test Case 002

    private readonly int _testcase002_n = 5;
    private readonly int _testcase002_output = 5;

    #endregion

    #region Test Case 001

    private readonly int _testcase003_n = 135;
    private readonly int _testcase003_output = 110;

    #endregion

    public CountSpecialIntegersTests()
    {
        _solution01 = new Solution01.Solution();
        _solution02 = new Solution02.Solution();
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.CountSpecialNumbers(_testcase001_n);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.CountSpecialNumbers(_testcase002_n);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.CountSpecialNumbers(_testcase003_n);
        Assert.Equal(_testcase003_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase001()
    {
        var output = _solution02.CountSpecialNumbers(_testcase001_n);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase002()
    {
        var output = _solution02.CountSpecialNumbers(_testcase002_n);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase003()
    {
        var output = _solution02.CountSpecialNumbers(_testcase003_n);
        Assert.Equal(_testcase003_output, output);
    }
}
