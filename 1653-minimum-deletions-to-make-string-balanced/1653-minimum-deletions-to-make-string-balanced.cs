public class Solution {
    //O(n)
    public int MinimumDeletions(string s) {
        int numB = 0;
        int minDel = 0;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i] == 'a')
            {
                minDel = Math.Min(minDel + 1, numB);
            }
            else
            {
                numB++;
            }
        }
    return minDel;
    }
}
 