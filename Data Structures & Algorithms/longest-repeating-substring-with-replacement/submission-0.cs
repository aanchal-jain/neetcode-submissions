public class Solution {
    public int CharacterReplacement(string s, int k) {
        var charSet = new HashSet<char>(s);
        var res = 0;
        foreach(char c in charSet){
            var l =0;
            var count = 0;
            for(int r = 0; r < s.Length; r++){
                if(s[r] == c){
                    count++;
                }
                while((r-l)+1 - count > k){
                    if(s[l]==c){
                        count--;
                    }
                    l++;
                }

                res = Math.Max(res, r-l+1);
            }
        }
       
       return res;
    }
}
