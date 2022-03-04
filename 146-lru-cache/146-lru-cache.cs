public class LRUCache {
    public class Cache
    {
        public int cacheKey;
        public int cacheValue;
        public Cache(int key, int value)
        {
            this.cacheKey = key;
            this.cacheValue = value;
        }
    }
    
    int capacity = 0;
    Dictionary<int, LinkedListNode<Cache>> dict;
    LinkedList<Cache> lruList;
    public LRUCache(int capacity) {
        dict = new Dictionary<int, LinkedListNode<Cache>>();
        lruList = new LinkedList<Cache>();
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if(!dict.ContainsKey(key))
            return -1;
        
        LinkedListNode<Cache> cache = dict[key];
        
        lruList.Remove(cache);
        lruList.AddFirst(cache);
        return cache.Value.cacheValue;
    }
    
    public void Put(int key, int value) {
        if(dict.ContainsKey(key))
        {
            dict[key].Value.cacheValue = value;

            LinkedListNode<Cache> cache = dict[key];
            lruList.Remove(cache);
            lruList.AddFirst(cache);
        }
        else
        {
            Cache cache = new Cache(key, value);
            dict.Add(key, new LinkedListNode<Cache>(cache));
            lruList.AddFirst(dict[key]);
            
            if(dict.Count > capacity)
            {
                LinkedListNode<Cache> lastNode = lruList.Last;
                dict.Remove(lastNode.Value.cacheKey);
                lruList.Remove(lastNode);
            }
        }
        
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */