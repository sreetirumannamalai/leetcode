public class Solution {
    public string ReverseWords(string s) {
        if(s == null || s == "") return null;
        StringBuilder sb = new StringBuilder();
        string[] words = s.Split(" ");
        for(int i = words.Length-1; i >= 0 ;i--)
        {
            if(!string.IsNullOrWhiteSpace(words[i]))
            {
                sb.Append(words[i]);
                sb.Append(" ");
            }
        }
        return sb.ToString().Trim();
    }
}