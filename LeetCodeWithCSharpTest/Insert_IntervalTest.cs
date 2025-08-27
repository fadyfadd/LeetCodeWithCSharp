using LeetCodeWithCSharp;
using Xunit;

namespace LeetCodeWithCSharpTest;

public class Insert_IntervalTest
{
    [Fact]
    public void mergeTowEntries_1()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 1, 10 }, new[] { 3, 5 });
        Assert.Single(result);
        Assert.Equal(new[] { 1, 10 }, result[0]);
    }
    
    [Fact]
    public void mergeTowEntries_2()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 4, 6 }, new[] { 1, 10 });
        Assert.Single(result);
        Assert.Equal(new[] { 1, 10 }, result[0]);
       
    }
    
    [Fact]
    public void mergeTowEntries_3()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 1, 5 }, new[] { 5, 8 });
        Assert.Single(result);
        Assert.Equal(new[] { 1, 8 }, result[0]);
    }
    
    [Fact]
    public void mergeTowEntries_4()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 5, 10 }, new[] { 1, 5 });
        Assert.Single(result);
        Assert.Equal(new[] { 1, 10 }, result[0]);
    }
    
    [Fact]
    public void mergeTowEntries_5()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 2, 10 }, new[] { 5, 11 });
        Assert.Equal(2 , result.Count);
        Assert.Equal(new[] { 2, 9 }, result[0]);
        Assert.Equal(new[] { 10, 11 }, result[1]);
    }
    
    [Fact]
    public void mergeTowEntries_6()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 8, 20 }, new[] { 5, 13 });
        Assert.Equal(2 , result.Count);
        Assert.Equal(new[] { 5, 12 }, result[0]);
        Assert.Equal(new[] { 13, 20 }, result[1]);
    }
    
    [Fact]
    public void mergeTowEntries_7()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 10, 20 }, new[] { 5, 15 });
        Assert.Equal(2 , result.Count);
        Assert.Equal(new[] { 5, 14 }, result[0]);
        Assert.Equal(new[] { 15, 20 }, result[1]);
    }
    
    [Fact]
    public void mergeTowEntries_8()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 5, 19 }, new[] { 8, 30 });
        Assert.Equal(2 , result.Count);
        Assert.Equal(new[] { 5, 18 }, result[0]);
        Assert.Equal(new[] { 19 ,30 }, result[1]);
    }
    
    [Fact]
    public void mergeTowEntries_9()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 2, 10 }, new[] { 10, 20 });
        Assert.Single(result);
        Assert.Equal(new[] { 2, 20 }, result[0]);
    }
    
    [Fact]
    public void mergeTowEntries_10()
    {
        var inst = new Insert_Interval();
        var result = inst.MergeTowEntries(new[] { 20, 30 }, new[] { 10, 20 });
        Assert.Single(result);
        Assert.Equal(new[] { 10, 30 }, result[0]);
    }
    
    
    
}