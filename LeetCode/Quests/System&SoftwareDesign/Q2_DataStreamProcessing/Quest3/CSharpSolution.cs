public class SummaryRanges
{
	public SortedList<int, LinkedSet> Ranges = new SortedList<int, LinkedSet>();

	public LinkedSet Root;
	public LinkedSet Tail;
	public int Count = 0;

	public SummaryRanges()
	{
	}

	public void AddNum(int value)
	{
		if (Ranges.ContainsKey(value))
		{
			return;
		}
		MergeSets(value);
	}

	public void MergeSets(int value)
	{
		var higherValue = value + 1;
		var lowerValue = value - 1;

		var containsNext = Ranges.ContainsKey(higherValue);
		var containsPrevious = Ranges.ContainsKey(lowerValue);
		if (containsNext && containsPrevious)
		{
			Ranges[higherValue].Min = value;
			Ranges.Add(value, Ranges[higherValue]);

			var previousSet = Ranges[lowerValue];
			Ranges[value].Redirect = previousSet;
			previousSet.Max = Ranges[value].Max;

			while (previousSet.Redirect != null)
			{
				previousSet.Redirect.Max = previousSet.Max;
				previousSet = previousSet.Redirect;
			}

			previousSet.Next = Ranges[value].Next;

			if (Ranges[value].Next == null)
			{
				Tail = previousSet;
			}
			else
			{
				previousSet.Next.Previous = previousSet;
			}

			Ranges[value].Next = null;
			Ranges[value].Previous = null;
			Count--;
		}
		else if (containsNext)
		{
			Ranges[higherValue].Min = value;
			Ranges.Add(value, Ranges[higherValue]);
		}
		else if (containsPrevious)
		{
			Ranges[lowerValue].Max = value;
			Ranges.Add(value, Ranges[lowerValue]);
			var previousSet = Ranges[lowerValue];
			while (previousSet.Redirect != null)
			{
				previousSet.Redirect.Max = previousSet.Max;
				previousSet = previousSet.Redirect;
			}
		}
		else
		{
			Count++;
			var set = new LinkedSet { Min = value, Max = value };
			Ranges.Add(value, set);
			if (Root == null)
			{
				Root = set;
				Tail = set;
				return;
			}

			var index = Ranges.IndexOfKey(value);
			if (index == 0)
			{
				set.Next = Root;
				Root.Previous = set;
				Root = set;
			}
			else if (index == Ranges.Count - 1)
			{
				set.Previous = Tail;
				Tail.Next = set;
				Tail = set;
			}
			else
			{
				var nextSet = Ranges.GetValueAtIndex(index + 1);
				set.Previous = nextSet.Previous;
				set.Next = nextSet;
				set.Previous.Next = set;
				set.Next.Previous = set;
			}
		}
	}

	public int[][] GetIntervals()
	{
		var intervals = new int[Count][];
		var counter = 0;
		var linkedSet = Root;
		while (linkedSet != null)
		{
			intervals[counter] = new int[] { linkedSet.Min, linkedSet.Max };
			linkedSet = linkedSet.Next;
			counter++;
		};
		return intervals;
	}
}

public class LinkedSet
{
	public LinkedSet Redirect { get; set; }
	public int Min { get; set; }
	public int Max { get; set; }
	public LinkedSet Previous { get; set; }
	public LinkedSet Next { get; set; }
}

/**
 * Your SummaryRanges object will be instantiated and called as such:
 * SummaryRanges obj = new SummaryRanges();
 * obj.AddNum(value);
 * int[][] param_2 = obj.GetIntervals();
 */