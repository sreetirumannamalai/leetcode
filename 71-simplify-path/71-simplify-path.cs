public class Solution {
    //Simplify Path
    //TC O(n) SC O(n);
   public string SimplifyPath(string path) {
      if(path.Length == 0 || path == null) return null;
       Stack<string> stk = new Stack<string>();
       string[] components = path.Split("/");
       for(int i= 0;i<components.Length;i++)
       {
           switch(components[i])
           {
               case ".":
               case "" :
                   break;
               case "..":
                   if(stk.Count > 0)
                   {
                     stk.Pop();
                   }
                   break;
               default:
                   stk.Push(components[i]);
                   break;
           }    
       }
       StringBuilder sb = new StringBuilder();
       List<string> list = new List<string>();
       while(stk.Count > 0)
       {
           list.Add(stk.Pop());
       }
       
       for(int i = list.Count - 1; i >=0; i--)
       {
           sb.Append("/");
           sb.Append(list[i]);
       }
       
       return sb.Length > 0 ? sb.ToString() : "/";
   }
}