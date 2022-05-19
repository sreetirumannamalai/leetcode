public class Solution {
    public int MinInsertions(string s) {
        if(s.Length == 0 || s== null) return 0;
        
        int[,] dp = new int[s.Length + 1, s.Length + 1];
        for(int length = 1; length <= s.Length; length++)
        {
            for(int start = 0;start < s.Length; start++)
            {
                int end = start + length;
                if(end > s.Length)
                    break;
                
                dp[start, end] = int.MaxValue;
                dp[start, end] = Math.Min(dp[start, end],dp[start + 1, end] + 1);
                dp[start, end] = Math.Min(dp[start, end],dp[start, end - 1] + 1);
                
                if(s[start] == s[end - 1])
                {
                    dp[start, end] = Math.Min(dp[start, end], dp[start + 1, end - 1]);
                }
            }
        }
        return dp[0, s.Length];
    }
}
  
        