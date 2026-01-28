public class LRUCache {
    private Dictionary<int, CacheNode> Cache;
    private int Capacity;
    private CacheNode InitialNode;
    private CacheNode LastNode;

    public LRUCache(int capacity) {
        Capacity = capacity;
        Cache = new Dictionary<int, CacheNode>(capacity);
    }
    
    public int Get(int key) {
        if(!Cache.ContainsKey(key))
        {
            return -1;
        }
        var node = Cache[key];

        MoveNodeToEnd(key);

        return node.Value;
    }
    
    public void Put(int key, int value) {
        if(Cache.ContainsKey(key))
        {
            var node = Cache[key];

            node.Value = value;
            MoveNodeToEnd(key);

            return;
        }
        if(Cache.Count < Capacity)
        {
            var newNode = new CacheNode(key, value);

            Cache.Add(key, newNode);

            AddNode(key);
        }
        else
        {
            var newNode = new CacheNode(key, value);

            Cache.Add(key, newNode);
            AddNode(key);

            RemoveLeastActivity();

        }
    }

    private void RemoveLeastActivity()
    {
        var nodeToRemove = InitialNode;
        Cache.Remove(nodeToRemove.Key);

        InitialNode = InitialNode.Next;
        InitialNode.Previous = null;
    }

    private void MoveNodeToEnd(int key)
    {
        if(!Cache.ContainsKey(key))
        {
            return;
        }

        var node = Cache[key];

        if(node.Next == null)
        {
            return;
        }

        if(node.Previous == null)
        {
            InitialNode = InitialNode.Next;
            InitialNode.Previous = null;
        }
        else
        {
            node.Next.Previous = node.Previous;
            node.Previous.Next = node.Next;
        }

        node.Previous = LastNode;
        node.Next = null;
        LastNode.Next = node;
        LastNode = node;
    }

    private void AddNode(int key)
    {
        if(!Cache.ContainsKey(key))
        {
            return;
        }

        var node = Cache[key];

        if(InitialNode != null)
        {
            node.Previous = LastNode;
            LastNode.Next = node;
            LastNode = node;
        }
        else
        {
            InitialNode = node;
            LastNode = node;
        }
    }
}

public class CacheNode
{
    public int Key {get;set;}
    public int Value {get;set;}
    public CacheNode Previous {get;set;}
    public CacheNode Next {get;set;}

    public CacheNode(int key, int value)
    {
        Key = key;
        Value = value;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */