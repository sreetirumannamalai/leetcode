public class Solution {
    //TC: O(nlogn) + O(mlogn) where n is the length of products and m is the length of the search word
    //here we treat string comparison in sorting as O(1)
    //O(nlogn) comes from the sorting and O(mlogn) comes from running binary search on products m times
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        List<IList<string>> list = new List<IList<string>>();
        Array.Sort(products);
        
        for(int i=0;i<searchWord.Length;i++)
        {
            string partWord = searchWord.Substring(0, i+1);
            List<string> innerList = new List<string>();
            
            for(int j = 0;j< products.Length;j++)
            {
                if(innerList.Count < 3 && products[j].Length > i)
                {
                    //for each product we are checking if part word is matching this product substring
                    string s = products[j].Substring(0,i+1);
                    if(s.Equals(partWord) && s.Length == partWord.Length)
                    {
                        innerList.Add(products[j]);
                    }
                }
            }
            list.Add(innerList);
        }
        return list;
    }
}
 
  