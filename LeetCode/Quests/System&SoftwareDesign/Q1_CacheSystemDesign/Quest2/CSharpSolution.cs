public class LFUCache {
    private Dictionary<int, CacheNode> Cache;
    private int Capacity;
    private NodeList FirstList;
    private NodeList LastList;

    public LFUCache(int capacity) {
        Capacity = capacity;
        Cache = new Dictionary<int, CacheNode>(capacity);
    }
    
    public int Get(int key) {
        if(!Cache.ContainsKey(key))
        {
            return -1;
        }

        var node = Cache[key];

        var list = node.List;

        list.UseNode(node);

        CleanupList(list);

        return node.Value;
    }
    
    public void Put(int key, int value) {
        if(Cache.ContainsKey(key))
        {
            var node = Cache[key];
            
            node.Value = value;

            var list = node.List;

            list.UseNode(node);

            CleanupList(list);

            return;
        }

        if(Cache.Count >= Capacity)
        {
            Cache.Remove(FirstList.RemoveFirstNode());
            if(FirstList.Count == 0)
            {
                FirstList = FirstList.NextList;
                if(FirstList != null)
                {
                    FirstList.PreviousList = null;
                }
            }
        }

        var newNode = new CacheNode(key, value);
        Cache.Add(key, newNode);

        if(FirstList == null)
        {
            var newList = new NodeList(newNode, 1);
            FirstList = newList;
            LastList = newList;
        }
        else if(FirstList.UsageCount > 1)
        {
            var newList = new NodeList(newNode, 1);

            FirstList.PreviousList = newList;
            newList.NextList = FirstList;
            FirstList = newList;
            
        }
        else
        {
            FirstList.AddNode(newNode);
        }
    }

    public void CleanupList(NodeList list)
    {
        if(list.Count == 0)
        {
            if(list.PreviousList == null)
            {
                FirstList = list.NextList;
            }
            list.Cleanup();
        }
    }
}

public class NodeList
{
    public int UsageCount {get;set;}
    public int Count {get;set;}

    public NodeList PreviousList {get;set;}
    public NodeList NextList {get;set;}

    public CacheNode FirstNode {get;set;}
    public CacheNode LastNode {get;set;}

    public NodeList(CacheNode initialNode, int usageCount)
    {
        Count = 1;
        UsageCount = usageCount;

        FirstNode = initialNode;
        LastNode = initialNode;
        initialNode.List = this;
    }

    public void AddNode(CacheNode node)
    {
        node.List = this;
        LastNode.Next = node;
        node.Previous = LastNode;
        LastNode = node;

        Count++;
    }

    public int RemoveFirstNode()
    {
        var oldKey = FirstNode.Key;
        FirstNode = FirstNode.Next;
        if(FirstNode != null)
        {
            FirstNode.Previous = null;
        }
        Count--;
        return oldKey;
    }

    public void UseNode(CacheNode node)
    {
        if(Count == 1)
        {
            if(NextList == null)
            {
                UsageCount++;
            }
            else if (NextList.UsageCount > UsageCount + 1)
            {
                UsageCount++;
            }
            else
            {
                NextList.AddNode(node);
                Count--;
            }

            return;
        }

        if(node.Next == null)
        {
            LastNode = node.Previous;
            LastNode.Next = null;
            node.Previous = null;
        }
        else if(node.Previous == null)
        {
            FirstNode = node.Next;
            FirstNode.Previous = null;
            node.Next = null;
        }
        else
        {
            node.Next.Previous = node.Previous;
            node.Previous.Next = node.Next;

            node.Next = null;
            node.Previous = null;
        }

        if(NextList == null)
        {
            NextList = new NodeList(node, UsageCount + 1);
            NextList.PreviousList = this;
        }
        else if (NextList.UsageCount > UsageCount + 1)
        {
            var newList = new NodeList(node, UsageCount + 1);

            newList.PreviousList = this;
            newList.NextList = NextList;
            NextList.PreviousList = newList;
            NextList = newList;
        }
        else
        {
            NextList.AddNode(node);
        }
        Count--;
    }
    
    public void Cleanup()
    {
        if(NextList != null)
        {
            NextList.PreviousList = PreviousList;
        }
        if(PreviousList != null)
        {
            PreviousList.NextList = NextList;
        }

        PreviousList = null;
        NextList = null;
    }
}

public class CacheNode
{
    public int Key {get;set;}
    public int Value {get;set;}
    public CacheNode Previous {get;set;}
    public CacheNode Next {get;set;}
    public NodeList List {get;set;}

    public CacheNode(int key, int value)
    {
        Key = key;
        Value = value;
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */