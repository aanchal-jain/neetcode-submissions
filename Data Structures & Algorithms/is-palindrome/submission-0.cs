public class Solution {
    public bool IsPalindrome(string s) {
        string reverseString="";
        foreach(char c in s){
            if(char.IsLetterOrDigit(c)){
                reverseString+=char.ToLower(c);
            }
        }
        
        return reverseString == new string(reverseString.Reverse().ToArray());
    }
}
