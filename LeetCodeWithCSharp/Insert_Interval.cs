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
            return output;
        }

        if (right[0] <= left[0] && right[1] >= left[1])
        {
            Int32[] res = { right[0], right[1] };
            output.Add(res);
            return output;
        }

        if (left[1] == right[0])
        {
            Int32[] res = { left[0], right[1] };
            output.Add(res);
            return output;
        }

        if (right[1] == left[0])
        {
            Int32[] res = { right[0], left[1] };
            output.Add(res);
            return output;
        }

        if (left[0] < right[1] && left[1] > right[1])
        {
            Int32[] res1 = { right[0], right[1] - 1 };
            Int32[] res2 = { right[1], left[1] };
            output.Add(res1);
            output.Add(res2);
            return output;
        }

        if (left[0] < right[0] && left[1] > right[0])
        {
            Int32[] res1 = { left[0], left[1] - 1 };
            Int32[] res2 = { left[1], right[1] };
            output.Add(res1);
            output.Add(res2);
            return output;
        }

        /*
        if (right[0] < left[1] && right[1] > left[1])
        {
            Int32[] res1 = { left[0], left[1] - 1 };
            Int32[] res2 = { left[1], right[1] };
            output.Add(res1);
            output.Add(res2);
            return output;
        }

        if (right[0] < left[0] && right[1] > left[0])
        {
            Int32[] res1 = { right[0], left[0] - 1 };
            Int32[] res2 = { left[0], left[1] };
            output.Add(res1);
            output.Add(res2);
            return output;
        }
        */
        
        if (left[1] < right[0])
        {
            Int32[] res = { left[0], right[1] };
            output.Add(res);
            return output;
        }

        /*
        if (right[1] < left[0])
        {
            Int32[] res = { right[0], left[1] };
            output.Add(res);
            return output;
        }
        */

        return null; 
    }

    public List<Int32[]> InsertInterval(Int32[][] main, Int32[] toInsert)
    {
        var results = new List<Int32[]>();
        var interval = main.ToList();
        interval.Insert(0 , toInsert);
        results.Add(interval[0]);

        for (int i = 1; i < interval.Count ; i++)
        {
            var arr1 = interval[i];
            var arr2 = results[results.Count - 1];
            
            results.RemoveAt(results.Count - 1);
            var arr3 = MergeTowEntries(arr1, arr2); 
          
            results.Add(arr3[0]);
            if (arr3.Count == 2)
                results.Add(arr3[1]);
        }

        return results;
    }
    
}