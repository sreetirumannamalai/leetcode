public class Solution {
    public string MinRemoveToMakeValid(string s) {
        if(s.Length == 0 || s == null) return null;
        StringBuilder sb = new StringBuilder();
        int open = 0;
        foreach(char c in s)
        {
            if(c == '(')
                open++;
            else if(c == ')')
            {
                if(open==0) 
                    continue;
                open--;
            }
            sb.Append(c);
        }
        StringBuilder result = new StringBuilder();
        for(int i=sb.Length - 1;i >= 0;i--)
        {
            if(sb[i] == '(' && open-- > 0)
                continue;
            
            result.Append(sb[i]);
        }
       string aa = result.ToString();

       var str = aa.ToCharArray().Reverse();

       return new string(str.ToArray());
    }
}