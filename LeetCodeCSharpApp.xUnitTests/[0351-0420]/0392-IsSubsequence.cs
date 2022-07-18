// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local
// ReSharper disable StringLiteralTypo

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.IsSubsequence01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class IsSubsequenceTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0392-Is Subsequence";    
    
    #region Test Case 001

    private readonly string _testcase001_s = "abc";
    private readonly string _testcase001_t = "ahbgdc";

    #endregion
    
    #region Test Case 002

    private readonly string _testcase002_s = "axc";
    private readonly string _testcase002_t = "ahbgdc";

    #endregion
    
    public IsSubsequenceTests()
    {
        _solution01 = new Solution01.Solution();
    }
    
    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.IsSubsequence(_testcase001_s, _testcase001_t);
        Assert.True(output);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.IsSubsequence(_testcase002_s, _testcase002_t);
        Assert.False(output);
    }
    
    #endregion
}
