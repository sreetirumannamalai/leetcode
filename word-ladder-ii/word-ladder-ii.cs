public class Solution {
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        List<IList<string>> result = new List<IList<string>>();
        if(beginWord.Length != endWord.Length) return result;
        
        HashSet<string> wordSet = new HashSet<string>(wordList);
        List<string> path = new List<string>() { beginWord};
        
        Queue<List<string>> queue = new Queue<List<string>>();
        queue.Enqueue(path);
        HashSet<string> visited = new HashSet<string>();
        bool found = false;
        
        while(queue.Count > 0)
        {
            int size = queue.Count;
            for(int i=0;i<size;i++)
            {
                List<string> currList = queue.Dequeue();
                string current = currList[currList.Count - 1];
                char[] arr = current.ToCharArray();
                for(int j=0;j<arr.Length;j++)
                {
                    char originalChar = arr[j];
                    for(char c='a'; c<= 'z';c++)
                    {
                        arr[j]=c;
                        string next = new string(arr);
                        if(wordSet.Contains(next))
                        {
                            visited.Add(next);
                            currList.Add(next);
                            if(next == endWord)
                            {
                                found = true;
                                result.Add(new List<string> (currList));
                            }
                            queue.Enqueue(new List<string>(currList));
                            currList.RemoveAt(currList.Count - 1);
                        }
                    }
                    arr[j] = originalChar;
                }
            }
            foreach(string str in visited)
            {
                wordSet.Remove(str);
            }
            
            if(found)
                break;
        }
        return result;
    }
}