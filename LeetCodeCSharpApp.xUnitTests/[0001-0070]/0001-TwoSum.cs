// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using Xunit;
using Solution01 = LeetCodeCSharpApp.TwoSum01;
using Solution02 = LeetCodeCSharpApp.TwoSum02;

namespace LeetCodeCSharpApp.xUnitTests;

public class TwoSumTests
{
    private readonly Solution01.Solution _solution01;
    private readonly Solution02.Solution _solution02;

    #region Test Case 001

    private readonly int[] _testcase001_nums = { 2, 7, 11, 15 };
    private readonly int _testcase001_target = 9;
    private readonly int[] _testcase001_output = { 0, 1 };

    #endregion

    #region Test Case 002

    private readonly int[] _testcase002_nums = { 3, 2, 4 };
    private readonly int _testcase002_target = 6;
    private readonly int[] _testcase002_output = { 1, 2 };

    #endregion

    #region Test Case 003

    private readonly int[] _testcase003_nums = { 3, 3 };
    private readonly int _testcase003_target = 6;
    private readonly int[] _testcase003_output = { 0, 1 };

    #endregion

    public TwoSumTests()
    {
        _solution01 = new Solution01.Solution();
        _solution02 = new Solution02.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", "0001-TwoSum Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.TwoSum(_testcase001_nums, _testcase001_target);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", "0001-TwoSum Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.TwoSum(_testcase002_nums, _testcase002_target);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", "0001-TwoSum Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.TwoSum(_testcase003_nums, _testcase003_target);
        Assert.Equal(_testcase003_output, output);
    }

    #endregion

    #region Solution-02

    [Fact]
    [Trait("Category", "0001-TwoSum Solution-02")]
    public void Solution02_TestCase001()
    {
        var output = _solution02.TwoSum(_testcase001_nums, _testcase001_target);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", "0001-TwoSum Solution-02")]
    public void Solution02_TestCase002()
    {
        var output = _solution02.TwoSum(_testcase002_nums, _testcase002_target);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", "0001-TwoSum Solution-02")]
    public void Solution02_TestCase003()
    {
        var output = _solution02.TwoSum(_testcase003_nums, _testcase003_target);
        Assert.Equal(_testcase003_output, output);
    }

    #endregion
}
