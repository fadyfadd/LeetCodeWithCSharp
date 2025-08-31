using LeetCodeWithCSharp;
using Xunit;

namespace LeetCodeWithCSharpTest;

public class Merge_SortTest
{
    private readonly Merge_Sort _mergeSort = new Merge_Sort();
    
    [Fact]
    public void InsertInterval_1()
    {
        var result = _mergeSort.MergeSort(new int[] {8, 40, 1, 10, 11, 12});
        Assert.Equal(result , new Int32[] {1,8,10,11,12,40});
    }

}