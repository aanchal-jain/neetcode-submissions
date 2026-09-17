public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var charSet = new HashSet<char>();
        var l = 0;
        var res = 0;

        for (int r = 0; r< s.Length; r++){
             while (charSet.Contains(s[r])) {
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]);
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
