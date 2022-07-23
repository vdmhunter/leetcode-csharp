// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.CountOfSmallerNumbersAfterSelf01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class CountOfSmallerNumbersAfterSelfTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0315-Count Of Smaller Numbers After Self";

    #region Test Case 001

    private readonly int[] _testcase001_nums = { 5, 2, 6, 1 };

    private readonly int[] _testcase001_output = { 2, 1, 1, 0 };

    #endregion

    #region Test Case 002

    private readonly int[] _testcase002_nums = { -1 };

    private readonly int[] _testcase002_output = { 0 };

    #endregion

    #region Test Case 003

    private readonly int[] _testcase003_nums = { -1, -1 };

    private readonly int[] _testcase003_output = { 0, 0 };

    #endregion
    
    #region Test Case 004

    private readonly int[] _testcase004_nums = Array.Empty<int>();

    private readonly int[] _testcase004_output = Array.Empty<int>();

    #endregion
    

    public CountOfSmallerNumbersAfterSelfTests()
    {
        _solution01 = new Solution01.Solution();
    }


    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.CountSmaller(_testcase001_nums);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.CountSmaller(_testcase002_nums);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.CountSmaller(_testcase003_nums);
        Assert.Equal(_testcase003_output, output);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase004()
    {
        var output = _solution01.CountSmaller(_testcase004_nums);
        Assert.Equal(_testcase004_output, output);
    }

    #endregion
}
