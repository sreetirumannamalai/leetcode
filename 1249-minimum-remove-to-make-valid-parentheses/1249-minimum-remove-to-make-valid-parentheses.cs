public class Solution {
    public string MinRemoveToMakeValid(string s) {
        if(s.Length == 0 || s == null) return null;
        int open =0;
        StringBuilder sb = new StringBuilder();
        foreach(char c in s.ToCharArray())
        {
            if(c == '(')
                open++;
            else if(c == ')')
            {
                if(open == 0) continue;
                
                open--;
            }
            sb.Append(c);
        }
        
        StringBuilder result = new StringBuilder();
        for(int i=sb.Length -1; i>=0;i--)
        {
            if(sb[i] == '(' && open-- > 0)
                continue;
                
            result.Append(sb[i]);
        }
        
        string aa = result.ToString();
        return new string(aa.ToCharArray().Reverse().ToArray());
    }
}
 