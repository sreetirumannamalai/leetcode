public class Solution {
    //TC O(n) SC O(n)
    public string MinRemoveToMakeValid(string s) {
        if(s == null || s.Length == 0) return "";
        int open = 0;
        StringBuilder sb = new StringBuilder();
        foreach(char c in s.ToCharArray())
        {
            if(c == '(')
                open++;
            else if(c == ')')
            {
                if(open == 0)
                    continue;
                
                open--;
            }
            sb.Append(c);
        }
        
        StringBuilder result = new StringBuilder();
        
        for(int i = sb.Length - 1; i >=0 ;i--)
        {
            if(sb[i] == '(' && open-- > 0 )
                continue;
            
            result.Append(sb[i]);
        }
        
        string str = result.ToString();
        return new String(str.Reverse().ToArray());
    }
}
 