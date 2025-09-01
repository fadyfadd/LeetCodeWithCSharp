using System;
using LeetCodeWithCSharp;
using Xunit;

namespace LeetCodeWithCSharpTest;


public class Two_SumTest
{
    private readonly Two_Sum _twoSum = new Two_Sum();

    [Fact]
    public void TwoSum_1()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

    
        int[] result = _twoSum.TwoSum(nums, target);

        Assert.Equal(new int[] { 0, 1 }, result);
    }

}
