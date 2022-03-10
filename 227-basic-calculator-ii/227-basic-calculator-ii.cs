public class Solution {
    public int Calculate(string s) {
        //O(n) sc O(1)
        if(s == null || s.Length == 0) return 0;
        int length = s.Length;
        int currentNumber = 0;
        int lastNumber = 0;
        int result = 0;
        char operation = '+';
        
        for(int i =0;i<length;i++)
        {
            char currentChar = s[i];
            if(Char.IsDigit(currentChar))
            {
                currentNumber = (currentNumber * 10) + (currentChar - '0');
            }
            if(!Char.IsDigit(currentChar) && 
               !Char.IsWhiteSpace(currentChar) ||
               i == length - 1)
            {
                if(operation == '+' || operation == '-')
                {
                    result += lastNumber;
                    lastNumber = (operation == '+') ? currentNumber : -currentNumber;
                }
                else if(operation == '*')
                {
                    lastNumber = lastNumber * currentNumber;
                }
                else if(operation == '/')
                {
                    lastNumber = lastNumber / currentNumber;
                }
                operation = currentChar;
                currentNumber = 0;
            }
        }
        result += lastNumber;
        return result;
    }
}