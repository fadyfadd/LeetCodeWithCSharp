namespace LeetCodeWithCSharp;

public class Two_Sum
{
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
}
