public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        //TC O(m2 * n) m is length of each word and n is total number of words
        if(wordList == null || wordList.Count == 0 || beginWord == null || endWord == null)
            return 0;
        HashSet<string> words = new HashSet<string>(wordList);
        words.Remove(beginWord);
        
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord);
        int level = 0;
        while(queue.Count > 0)
        {
            int size = queue.Count;
            level++;
            for(int i =0;i<size;i++)
            {
                string currentWord = queue.Dequeue();
                if(currentWord.Equals(endWord))
                    return level;
                
                List<string> neighbors = GetNeighbors(currentWord);
                foreach(string neighbor in neighbors)
                {
                    if(words.Contains(neighbor))
                    {
                        words.Remove(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
        return 0;
    }
    
    public List<string> GetNeighbors(string currentWord)
    {
        List<string> result = new List<string>();
        char[] chars = currentWord.ToCharArray();
        for(int i=0;i<chars.Length;i++)
        {
            char temp = chars[i];
            for(char c = 'a'; c <= 'z'; c++)
            {
                chars[i] = c;
                string newstring = new string(chars);
                result.Add(newstring);
            }
            chars[i] = temp;
        }
        return result;
    }
}
   