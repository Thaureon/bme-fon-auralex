public class KthLargest
{

	public Tree LargestTree { get; set; }

	public KthLargest(int k, int[] nums)
	{
		LargestTree = new Tree(k);
		LargestTree.AddInitialNodes(nums);
	}

	public int Add(int val)
	{
		LargestTree.AddNode(val);
		return LargestTree.GetKthValue();
	}
}

public class Tree
{
	public Node Root { get; set; }
	public int LargestPosition { get; set; }

	public Tree(int largestPosition)
	{
		LargestPosition = largestPosition;
	}

	public int GetKthValue()
	{
		return Root.Value;
	}

	public void AddNode(int nodeValue)
	{
		var newNode = new Node(nodeValue);
		var addedNode = false;
		var currentNode = Root;

		if (Root == null)
		{
			Root = newNode;
			return;
		}

		if ((Root.Right?.Count ?? 0) < LargestPosition - 1)
		{
			if (Root.Value >= newNode.Value)
			{
				newNode.Left = Root.Left;
				newNode.Right = Root;
				Root.Left = null;
				Root = newNode;

				var oldRoot = Root.Left;
				if(oldRoot != null)
				{
					oldRoot.Count = (oldRoot.Left?.Count ?? 0) + (oldRoot.Right?.Count ?? 0) + 1;
				}

				Root.Count = (Root.Left?.Count ?? 0) + (Root.Right?.Count ?? 0) + 1;
				return;
			}
		}

		while (!addedNode)
		{
			currentNode.Count++;
			if (currentNode.Value >= newNode.Value)
			{
				if (currentNode.Left == null)
				{
					currentNode.Left = newNode;
					addedNode = true;
				}
				currentNode = currentNode.Left;
			}
			else
			{
				if (currentNode.Right == null)
				{
					currentNode.Right = newNode;
					addedNode = true;
				}
				currentNode = currentNode.Right;
			}
		}
		Recenter();
	}

	public void AddInitialNodes(int[] values)
	{
		foreach (var value in values)
		{
			if (Root == null)
			{
				var newNode = new Node(value);
				Root = newNode;
				continue;
			}

			AddNode(value);
		}
	}

	public void Recenter()
	{
		var newRootNode = Root.Right;

		if (newRootNode == null)
		{
			return;
		}

		if (Root.Right.Count < LargestPosition)
		{
			return;
		}

		var previousNode = Root;

		while (newRootNode.Left != null)
		{
			newRootNode.Count--;
			previousNode = newRootNode;
			newRootNode = newRootNode.Left;
		}

		if (previousNode != Root)
		{
			previousNode.Left = newRootNode.Right;
			newRootNode.Left = Root;
			newRootNode.Right = Root.Right;
		}
		Root.Right = null;
		Root = newRootNode;

		var oldRoot = Root.Left;
		if(oldRoot != null)
		{
			oldRoot.Count = (oldRoot.Left?.Count ?? 0) + (oldRoot.Right?.Count ?? 0) + 1;
		}

		Root.Count = (Root.Left?.Count ?? 0) + (Root.Right?.Count ?? 0) + 1;
	}
}

public class Node
{
	public int Value { get; set; }
	public int Count { get; set; }
	public Node Left { get; set; }
	public Node Right { get; set; }

	public Node(int value)
	{
		Value = value;
		Count = 1;
	}
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */