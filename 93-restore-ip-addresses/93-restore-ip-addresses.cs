public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        List<string> result = new List<string>();
        
        //using backtracking
        if(s.Length > 12)
            return result;
        
        Helper(0,0,s,new List<string>(), result);
        return result;
    }
    
    public void Helper(int index, int dots, string s, List<string> lst, List<string> result)
    {
        if(dots  == 4 && index == s.Length)
            result.Add(string.Join('.', lst));
        
        if(dots == 4 && index != s.Length)
            return;
        
        for(int i=1; i<4 && index + i <= s.Length; i++)
        {
            if(IsValid(s, index, i))
            {
                lst.Add(s.Substring(index, i));
                Helper(index + i, dots + 1, s, lst, result);
                lst.RemoveAt(lst.Count - 1);
            }
        }
    }
    
    public bool IsValid(string s, int index, int len)
    {
        string sub = s.Substring(index, len);
        if((sub.Length > 1 && sub[0] == '0') || Convert.ToInt32(sub) > 255)
            return false;
        
        return true;
    }
}
              