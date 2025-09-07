#r "nuget:xunit, 2.5.0"
using Xunit;

public List<Int32[]> MergeTwoEntries(Int32[] a, Int32[] b)
{
    Int32[] left = a[0] <= b[0] ? a : b;
    Int32[] right = a[0] <= b[0] ? b : a;

    if (left[1] >= right[0])
    {
        int mergedEnd = Math.Max(left[1], right[1]);
        return new List<Int32[]> { new Int32[] { left[0], mergedEnd } };
    }
    else
    {
        return new List<Int32[]> { left, right };
    }
}

public List<Int32[]> InsertInterval(Int32[][] main, Int32[] toInsert)
{
    var results = new List<Int32[]>();
    var interval = main.ToList();
    interval.Insert(0, toInsert);
    interval = interval.OrderBy(x => x[0]).ToList();

    results.Add(interval[0]);

    for (int i = 1; i < interval.Count; i++)
    {
        var arr1 = interval[i];
        var arr2 = results[results.Count - 1];

        results.RemoveAt(results.Count - 1);
        var arr3 = MergeTwoEntries(arr1, arr2);

        results.Add(arr3[0]);
        if (arr3.Count == 2)
            results.Add(arr3[1]);
    }

    return results;
}

{
    Int32[][] main = new Int32[][] {
            new Int32[] {1, 3},
            new Int32[] {6, 9}
        };
    Int32[] toInsert = new Int32[] { 2, 5 };

    var result = InsertInterval(main, toInsert);

    Assert.Equal(new[] { 1, 5 }, result[0]);
    Assert.Equal(new[] { 6, 9 }, result[1]);
}

