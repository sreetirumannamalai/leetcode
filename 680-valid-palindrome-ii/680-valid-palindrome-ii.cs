public class Solution {
    //Valid Palindrome II
    //TC O(n) SC O(1)
    public bool ValidPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;
        while(i<j)
        {
            if(s[i] != s[j])
                return IsPalindrome(s, i+1, j) || IsPalindrome(s, i, j-1);
                
            i++;
            j--;
        }
        return true;
    }
    
    public bool IsPalindrome(string s, int i, int j)
    {
        while(i < j)
        {
            if(s[i] != s[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}