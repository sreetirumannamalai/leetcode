public class Solution {
    public IList<string> LetterCombinations(string digits) {
        List<string> result = new List<string>();
        if(digits != null && digits.Length > 0)
        {
            string[] map = {"","","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
            LetterCombinations_DFS(digits, map, result, new StringBuilder(), 0);
        }
        return result;        
    }
    
    public void LetterCombinations_DFS(string digits, string[] map, List<string> result, StringBuilder sb, int index)
    {
        //base case
        if(index == digits.Length)
        {
            result.Add(sb.ToString());
            return;
        }
        
        //get each character from the string
        int number = int.Parse(digits[index].ToString());
        //get the string for that number from the map
        string letterString = map[number];
        for(int i=0;i<letterString.Length;i++)
        {
            char ch = letterString[i];
            sb.Append(ch);
            LetterCombinations_DFS(digits, map, result, sb, index + 1);
            sb.Remove(sb.Length - 1, 1);
        }
    }
}