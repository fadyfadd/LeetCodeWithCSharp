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

{
    string s = "[(1+2)*{3+4}]";
    bool result = IsValidParenthesis(s);
    Assert.True(result);
}

{
    string s = "[(1+2)*{3+4]";
    bool result = _validParenthesis.IsValidParenthesis(s);
    Assert.False(result);
}