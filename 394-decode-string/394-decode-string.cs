public class Solution {
    //O(m * n) sc O(m + n)
    public string DecodeString(string s) {
        if(s == null || s == string.Empty) return "";
        
        Stack<string> wordStack = new Stack<string>();
        Stack<int> countStack = new Stack<int>();
        StringBuilder sb = new StringBuilder();
        int number = 0;
        
        for(int i=0; i<s.Length;i++)
        {
            char c = s[i];
            if(Char.IsDigit(c))
            {
                number = number * 10 + (c-'0');
            }
            else if(Char.IsLetter(c))
            {
                sb.Append(c);
            }
            else if(c == '[')
            {
                countStack.Push(number);
                wordStack.Push(sb.ToString());
                number = 0;
                sb = new StringBuilder();
            }
            else
            {
                int count = countStack.Pop();
                StringBuilder duplicateWord = new StringBuilder(wordStack.Pop());
                for(int j =0;j<count;j++)
                {
                    duplicateWord.Append(sb);
                }
                sb = duplicateWord;
            }
        }
        return sb.ToString();
    }
}