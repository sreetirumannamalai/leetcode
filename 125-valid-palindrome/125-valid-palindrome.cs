public class Solution {
    //Valid Palindrome
    //TC O(n) SC O(1)
    public bool IsPalindrome(string s) {
        if(s.Length == 0) return true;
        if(s == null) return false;
        
        int low = 0;
        int high = s.Length -1;
        while(low < high)
        {
            while(low < high && !Char.IsLetterOrDigit(s[low]))
            {
                low++;
            }
            while(low < high && !Char.IsLetterOrDigit(s[high]))
            {
                high--;
            }
            
            if(low < high && Char.ToLower(s[low++]) != Char.ToLower(s[high--]))
                return false;
        }
        return true;
    }
}  
 