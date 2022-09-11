public class Solution {
    //Simplify Path
    //TC O(n) SC O(n);
   public string SimplifyPath(string path) {
       string[] components = path.Split('/');
       Stack<string> stk = new Stack<string>();
       for(int i =0;i<components.Length;i++)
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
         
       StringBuilder res = new StringBuilder();
       List<string> list = new List<string>();
       
       while(stk.Count > 0)
       {
            list.Add(stk.Pop());
       }
         
       for(int i=list.Count - 1; i >= 0; i--)
       {
            res.Append("/");
            res.Append(list[i]);
       }
       
        return res.Length > 0 ? res.ToString() : "/"; 
    }
}