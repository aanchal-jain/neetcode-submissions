public class Solution {
    public bool IsPalindrome(string s) {
        var i =0;
        var j=s.Length-1;

        while(i<j){
            while(i<j && !char.IsLetterOrDigit(s[i])){
                i++;
            }
            while(i<j && !char.IsLetterOrDigit(s[j])){
                j--;
            }

            if(char.ToLower(s[i]) != char.ToLower(s[j])){
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}
