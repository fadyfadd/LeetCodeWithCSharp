using LeetCodeWithCSharp;
using Xunit;

namespace LeetCodeWithCSharpTest;

public class Insert_IntervalTest
{
    private readonly Insert_Interval _insertInterval = new Insert_Interval();
    
 
    [Fact]
    public void InsertInterval_1()
    {
        Int32[][] main = new Int32[][] {
            new Int32[] {1, 3},
            new Int32[] {6, 9}
        };
        Int32[] toInsert = new Int32[] {2, 5};

        var result = _insertInterval.InsertInterval(main, toInsert);
        
        Assert.Equal(new[] { 1, 5 }, result[0]);
        Assert.Equal(new[] {6, 9 }, result[1]);
        


    }
}