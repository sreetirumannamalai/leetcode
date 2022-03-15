public class Solution {
    //O(n + m + Max(n,m)) sc O(n + m) m and n are length of input strings
    public int CompareVersion(string version1, string version2) {
        string[] s1 = version1.Split(".");
        string[] s2 = version2.Split(".");
        int maxLength = Math.Max(s1.Length, s2.Length);
        for(int i=0;i<maxLength;i++)
        {
            int v1 = int.Parse(i<s1.Length ? s1[i] : "0");
            int v2 = int.Parse(i<s2.Length ? s2[i] : "0");
            
            if(v1 < v2) 
                return -1;
            else if(v1 > v2) 
                return 1;
        }
        return 0;
    }
} 