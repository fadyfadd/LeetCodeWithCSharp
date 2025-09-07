#r "nuget:xunit, 2.5.0"
using Xunit;

public Int32[] TwoSum(Int32[] nums, Int32 target)
{
    Dictionary<Int32, Int32> map = new Dictionary<Int32, Int32>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];

        if (map.ContainsKey(complement))
        {
            return new Int32[] { map[complement], i };
        }

        if (!map.ContainsKey(nums[i]))
        {
            map.Add(nums[i], i);
        }
    }

    return new Int32[] { -1, -1 };
}


{
    int[] nums = { 2, 7, 11, 15 };
    int target = 9;

    int[] result = TwoSum(nums, target);

    Assert.Equal(new int[] { 0, 1 }, result);
}