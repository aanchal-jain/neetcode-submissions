public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs){
            char[] charArr = s.ToCharArray();
            Array.Sort(charArr);
            string sortedS = new string(charArr);
            if (!res.ContainsKey(sortedS)){
                res[sortedS] = new List<string>();
            }
            res[sortedS].Add(s);
        }

        return res.Values.ToList<List<string>>();
    }
}
