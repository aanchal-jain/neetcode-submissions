public class Solution {

public string Encode(IList<string> strs)
{
    if (strs.Count == 0)
    {
        return "";
    }

    var strCount = strs.Count();
    var res = new StringBuilder();
    foreach (var str in strs)
    {
        res.Append($"{str.Length}#{str}");
    }

    return res.ToString();
}

public List<string> Decode(string s)
{
    if (s.Length == 0)
    {
        return [];
    }

    var charCount = 0;
    var charStart = 0;
    var result = new List<string>();
    for (int i = 0; i < s.Length;)
    {
        if (s[i] != '#')
        {
            charCount++;
            i++;
        }
        else
        {
            var strLen = int.Parse(s.Substring(charStart, charCount));
            var str = s.Substring(i + 1, strLen);
            charCount = 0;
            charStart = i + strLen + 1;
            i = charStart;
            result.Add(str);
        }
    }

    return result;
}
}
