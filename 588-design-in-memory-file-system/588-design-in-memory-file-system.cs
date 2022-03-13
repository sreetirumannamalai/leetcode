public class FileSystem {
    public string current = "/";
    public Dictionary<string, string> files = new Dictionary<string, string>();
    public Dictionary<string, IList<string>> dirs = new Dictionary<string, IList<string>>();
    
    public FileSystem() {
        dirs["/"] = new List<string>();
    }
    
    public IList<string> Ls(string path) {
        if(files.ContainsKey(path))
        {
            return new List<string>{
                path.Substring(path.LastIndexOf('/') + 1)};
        }
        
        if(dirs.ContainsKey(path))
        {
            //return directly when its a dir
            var list = new List<string>(dirs[path]);
            list.Sort((a,b) => a.CompareTo(b));
            return list;
        }
        return new List<string>();
    }
    
    public void Mkdir(string path) {
        var ds = path.Split(new char[]{'/'}, StringSplitOptions.RemoveEmptyEntries);
        var dir = dirs;
        var p= "";
        var pre = "/";
        for(var i=0;i<ds.Length;i++)
        {
            p += "/" + ds[i];
            if(!dirs.ContainsKey(p))
            {
                dirs[p] = new List<string>();
                dirs[pre].Add(ds[i]);
            }
            pre = p;
        }
    }
    
    public void AddContentToFile(string filePath, string content) {
        if(files.ContainsKey(filePath))
        {
            files[filePath] += content;
        }
        else
        {
            files[filePath] = content;
            Mkdir(filePath);
        }
    }
    
    public string ReadContentFromFile(string filePath) {
        if(files.ContainsKey(filePath))
            return files[filePath];
        
        return null;
    }
}

/**
 * Your FileSystem object will be instantiated and called as such:
 * FileSystem obj = new FileSystem();
 * IList<string> param_1 = obj.Ls(path);
 * obj.Mkdir(path);
 * obj.AddContentToFile(filePath,content);
 * string param_4 = obj.ReadContentFromFile(filePath);
 */