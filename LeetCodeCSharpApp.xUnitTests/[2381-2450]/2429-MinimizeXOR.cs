// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.MinimizeXOR01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class MinimizeXOR
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "2429-Minimize XOR";

    #region Test Case 001

    private readonly int _testcase001_num1 = 3;
    private readonly int _testcase001_num2 = 5;
    private readonly int _testcase001_output = 3;

    #endregion

    #region Test Case 002

    private readonly int _testcase002_num1 = 1;
    private readonly int _testcase002_num2 = 12;
    private readonly int _testcase002_output = 3;

    #endregion

    public MinimizeXOR()
    {
        _solution01 = new Solution01.Solution();
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.MinimizeXor(_testcase001_num1, _testcase001_num2);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.MinimizeXor(_testcase002_num1, _testcase002_num2);
        Assert.Equal(_testcase002_output, output);
    }
}
