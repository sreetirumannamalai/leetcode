public class Solution {
    //TC O(n) SC O(n)
    public string MinRemoveToMakeValid(string s) {
       if(s.Length == 0 || s == null) return "";
        
        StringBuilder sb = new StringBuilder();
        int open = 0;
        foreach(char c in s.ToCharArray())
        {
            if(c == '(')
                open++;
            else if(c==')')
            {
                if(open==0) continue;
                
                open--;
            }
            sb.Append(c);
        }
        
        StringBuilder result = new StringBuilder();
        for(int i = sb.Length-1;i>=0;i--)
        {
            if(sb[i] == '(' && open-- > 0)
                continue;
            
            result.Append(sb[i]);
        }
        string str = result.ToString();
        return new String(str.Reverse().ToArray());
    }
}
 