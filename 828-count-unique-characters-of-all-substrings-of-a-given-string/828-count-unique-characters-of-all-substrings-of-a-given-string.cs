public class Solution {
    //O(n) sc O(1)
    public int UniqueLetterString(string s) {
        int res = 0;
        int mod = 1000000007;
        int[][] index = new int[26][];
        for (int i = 0; i < 26; i++)
            index[i] = new int[] { -1, -1 };        
        for (int i = 0; i < s.Length; i++) {
            int c = s[i] - 'A';
            res = (res + (i - index[c][1]) * (index[c][1] - index[c][0]) % mod) % mod;
            index[c][0] = index[c][1];
            index[c][1] = i;
        }
        for (int c = 0; c < 26; c++)
            res = (res + (s.Length - index[c][1]) * (index[c][1] - index[c][0]) % mod) % mod;
        return res;
    }
}