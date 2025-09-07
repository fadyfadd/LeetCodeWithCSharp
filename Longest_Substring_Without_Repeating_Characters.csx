#r "nuget:xunit, 2.5.0"
using Xunit;

public string LongestSubstringWithoutRepeating(string s)
{
    if (string.IsNullOrEmpty(s))
        return string.Empty;

    int left = 0;
    int right = 0;
    int maxLength = 0;
    int startIndex = 0;

    Dictionary<char, int> map = new Dictionary<char, int>();

    while (right < s.Length)
    {
        char currentChar = s[right];

        if (map.ContainsKey(currentChar) && map[currentChar] >= left)
        {
            left = map[currentChar] + 1;
        }

        map[currentChar] = right;

        if (right - left + 1 > maxLength)
        {
            maxLength = right - left + 1;
            startIndex = left;
        }

        right++;
    }

    return s.Substring(startIndex, maxLength);
}

{
    var result = LongestSubstringWithoutRepeating("abcabcbb");
    Assert.Equal("abc", result);
}

{
    var result = LongestSubstringWithoutRepeating("bbbbb");
    Assert.Equal("b", result);
}

{
    var result = LongestSubstringWithoutRepeating("pwwkew");
    Assert.Equal("wke", result);
}