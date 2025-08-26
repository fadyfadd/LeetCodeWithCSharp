namespace LeetCodeWithCSharp;

public class Insert_Interval
{
    public List<Int32[]> MergeTowEntries(Int32[] left, Int32[] right)
    {
        List<Int32[]> output = new List<Int32[]>();

        if (left[0] <= right[0] && left[1] >= right[1])
        {
            Int32[] res = { left[0], left[1] };
            output.Add(res);
        }

        if (right[0] <= left[0] && right[1] >= left[1])
        {
            Int32[] res = { right[0], right[1] };
            output.Add(res);
        }

        if (left[1] == right[0])
        {
            Int32[] res = { left[0], right[1] };
            output.Add(res);
        }

        if (right[1] == left[0])
        {
            Int32[] res = { right[0], left[1] };
            output.Add(res);
        }

        if (left[0] < right[1] && left[1] > right[1])
        {
            Int32[] res1 = { right[0], right[1] - 1 };
            Int32[] res2 = { right[1], left[1] };
            output.Add(res1);
            output.Add(res2);
        }

        if (left[0] < right[0] && left[1] > right[0])
        {
            Int32[] res1 = { left[0], right[0] - 1 };
            Int32[] res2 = { right[0], right[1] };
            output.Add(res1);
            output.Add(res2);
        }

        if (right[0] < left[1] && right[1] > left[1])
        {
            Int32[] res1 = { left[0], left[1] - 1 };
            Int32[] res2 = { left[1], right[1] };
            output.Add(res1);
            output.Add(res2);
        }

        if (right[0] < left[0] && right[1] > left[0])
        {
            Int32[] res1 = { right[0], left[0] - 1 };
            Int32[] res2 = { left[0], left[1] };
            output.Add(res1);
            output.Add(res2);
        }

        if (left[1] < right[0])
        {
            Int32[] res = { left[0], right[1] };
            output.Add(res);
        }

        if (right[1] < left[0])
        {
            Int32[] res = { right[0], left[1] };
            output.Add(res);
        }

        return output;
    }
}