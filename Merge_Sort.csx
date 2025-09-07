#r "nuget:xunit, 2.5.0"
using Xunit;
public Int32[] MergeMicroArrays(Int32[] nums1, Int32[] nums2)
{
    Int32 a = 0;
    Int32 b = 0;


    List<Int32> result = new List<Int32>();

    while (a < nums1.Length && b < nums2.Length)
    {
        if (nums1[a] < nums2[b])
        {
            result.Add(nums1[a]);
            a++;
        }
        else
        {
            result.Add(nums2[b]);
            b++;

        }
    }

    while (a < nums1.Length)
    {
        result.Add(nums1[a]);
        a++;
    }

    while (b < nums2.Length)
    {
        result.Add(nums2[b]);
        b++;
    }

    return result.ToArray();
}
public Int32[] MergeSort(Int32[] nums)
{
    if (nums.Length <= 1)
        return nums;

    Int32 mid = nums.Length / 2;
    Int32[] i1 = nums[0..mid];
    Int32[] i2 = nums[mid..nums.Length];

    var merged_i1 = MergeSort(i1);
    var merged_i2 = MergeSort(i2);

    return MergeMicroArrays(merged_i1, merged_i2);

}

{
    var result = MergeSort(new int[] { 8, 40, 1, 10, 11, 12 });
    Assert.Equal(result, new Int32[] { 1, 8, 10, 11, 12, 40 });
}