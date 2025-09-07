#r "nuget:xunit, 2.5.0"
using Xunit;
    
public bool IsValidParenthesis(string s)
{

    var stack = new Stack<char>();

    foreach (var c in s)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else
        {
            if (stack.Count == 0)
                return false;

            if (c != ')' && c != '}' && c != ']')
                continue;
                
            var top = stack.Pop();
            if ((c == ')' && top != '(') ||
                (c == '}' && top != '{') ||
                (c == ']' && top != '['))
            {
                return false;
            }
        }
    }

    return stack.Count == 0;
}

{       int[] nums = { 2, 7, 11, 15 };
        int target = 9;

    
        int[] result = _twoSum.TwoSum(nums, target);

        Assert.Equal(new int[] { 0, 1 }, result);

}