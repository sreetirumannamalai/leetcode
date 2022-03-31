
public class AutocompleteSystem {

    public class TrieNode
    {
        public TrieNode[] children;
        public char val;
        public int times;
        public TrieNode(char ch)
        {
            this.children=new TrieNode[256];
            this.val=ch;
        }
    }
    public class Trie
    {
        public TrieNode root;
        public Trie()
        {
            this.root=new TrieNode('_');
        }
        public void Add(string str,int time)
        {
            var cur=root;
            for(int i=0;i<str.Length;i++)
            {
                var ch=str[i];
                if(cur.children[ch]==null)cur.children[ch]=new TrieNode(ch);
                cur=cur.children[ch];
            }
            cur.times=time;
        }
        public List<string> find(string str)
        {
            var ret=new List<string>();
            var cur=this.root;
            for(int i=0;i<str.Length;i++)
            {
                char ch=str[i];
                if(cur.children[ch]==null)return ret;
                cur=cur.children[ch];
            }
            dfs(cur,str,ret);
            return ret;
        }
        void dfs(TrieNode cur,string str,List<string> ret)
        {
            if(cur==null)return;
            if(cur.times>0)ret.Add(str);
            for(int i=0;i<cur.children.Length;i++)
            {
                if(cur.children[i]!=null)
                {
                    dfs(cur.children[i],str+cur.children[i].val,ret);
                }
            }
        }
    }
    
    private Trie trie;
    private StringBuilder sb;
    private Dictionary<string,int> dict=new Dictionary<string,int>();
    
    public AutocompleteSystem(string[] sentences, int[] times) {
        trie=new Trie();
        sb=new StringBuilder();
        for(int i=0;i<sentences.Length;i++)
        {
            trie.Add(sentences[i],times[i]);
            dict.Add(sentences[i],times[i]);
        }
    }
    
    public IList<string> Input(char c) {
        var ret=new List<string>();
        if(c=='#')
        {
            if(!dict.ContainsKey(sb.ToString()))dict.Add(sb.ToString(),0);
            dict[sb.ToString()]++;
            trie.Add(sb.ToString(),dict[sb.ToString()]);
            sb=new StringBuilder();
        }
        else
        {
            sb.Append(c);
            ret=trie.find(sb.ToString());
        }
        return ret.OrderByDescending(x=>dict[x]).ThenBy(x=>x,StringComparer.Ordinal).Take(3).ToList();
    }
}


/**
 * Your AutocompleteSystem object will be instantiated and called as such:
 * AutocompleteSystem obj = new AutocompleteSystem(sentences, times);
 * IList<string> param_1 = obj.Input(c);
 */