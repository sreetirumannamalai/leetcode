public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        int pos = 0;
        int count = 0;
        for(int i = 0;i < abbr.Length; i++)
        {
            char c = abbr[i];
            if(c >= '0' && c<='9')
            {
                if(count == 0 && c == '0') return false;
                count = count * 10 + (c - '0');
            }
            else
            {
                pos += count;
                count = 0;
                if(pos >= word.Length || c != word[pos])
                    return false;
                pos++;
            }
        }
        return pos + count == word.Length;
    }
}
 