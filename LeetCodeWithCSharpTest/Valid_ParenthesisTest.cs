using System;
using LeetCodeWithCSharp;
using Xunit;

namespace LeetCodeWithCSharpTest;

public class Valid_ParenthesisTest
{
    private readonly Valid_Parenthesis _validParenthesis = new Valid_Parenthesis();


    [Fact]
    public void IsValidParenthesis_1()
    {
        string s = "[(1+2)*{3+4}]";
        bool result = _validParenthesis.IsValidParenthesis(s);
        Assert.True(result);
    }

    [Fact]
    public void IsValidParenthesis_2()
    {
        string s = "[(1+2)*{3+4]";
        bool result = _validParenthesis.IsValidParenthesis(s);
        Assert.False(result);
    }

}
