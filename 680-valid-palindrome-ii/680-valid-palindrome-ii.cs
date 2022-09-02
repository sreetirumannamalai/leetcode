public class Solution {
    //Valid Palindrome II
    //TC O(n) SC O(1)
    public bool ValidPalindrome(string s) {
        int i = 0;
        int j = s.Length-1;
        while(i < j)
        {
            if(s[i] != s[j])
                return IsPalindrome(s, i, j-1) || IsPalindrome(s, i+1, j);
        
            i++;
            j--;
        }
        return true;
    }
    
      public bool IsPalindrome(string s, int left, int right)
      {
        while(left < right)
        {
            if(s[left] != s[right])
                return false;
        
            left++;
            right--;
        }
        return true;
    }
}