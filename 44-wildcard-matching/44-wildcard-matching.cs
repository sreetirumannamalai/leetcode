public class Solution {
    //O(m * n) sc O(n)
    public bool IsMatch(string s, string p) {
        char[] str = s.ToCharArray();
        char[] pattern = p.ToCharArray();
        //if the pattern contains multiple *'s replacing multiple * with one *
        //a*****b**c
        int writeIndex = 0;
        bool isFirst = true;
        for(int i=0;i<pattern.Length;i++)
        {
            if(pattern[i] == '*')
            {
                if(isFirst)
                {
                    pattern[writeIndex] = pattern[i];
                    writeIndex++;
                    isFirst = false;
                 }
            }
            else
            {
                pattern[writeIndex] = pattern[i];
                writeIndex++;
                isFirst = true;
            }
        }
        
        bool[][] T = new bool[str.Length+1][];
        for(int i=0;i<str.Length + 1;i++)
        {
            T[i] = new bool[pattern.Length + 1];
        }
        
        T[0][0] = true;
        
        if(writeIndex > 0 && pattern[0] == '*')
        {
            T[0][1] = true;
        }
        
        for(int i = 1;i<T.Length;i++)
        {
            for(int j = 1;j<T[0].Length;j++)
            {
                if(pattern[j-1] == '?' || str[i-1] == pattern[j-1])
                {
                    T[i][j] = T[i-1][j-1];
                }
                else if(pattern[j-1] == '*')
                {
                    T[i][j] = T[i-1][j] || T[i][j-1];
                }
            }
        }
        return T[str.Length][writeIndex];
    }
}