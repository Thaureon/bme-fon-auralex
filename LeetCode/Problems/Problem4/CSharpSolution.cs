
public class Solution
{
	public double FindMedianSortedArrays(int[] nums1, int[] nums2)
	{
		var median = 0.0;
		var foundMedian = false;
		
		if(!nums1.Any())
		{
			var left = nums2[(nums2.Length - 1) / 2];
			var right = nums2[nums2.Length / 2];
			return (left + right) / 2.0;
		}
		if (!nums2.Any())
		{
			var left = nums1[(nums1.Length - 1) / 2];
			var right = nums1[nums1.Length / 2];
			return (left + right) / 2.0;
		}

		if (nums1[nums1.Length - 1] <= nums2[0])
		{
			median = FindMedianSortedArraysOrdered(nums1, nums2);
			foundMedian = true;
		}
		else if (nums1[0] >= nums2[nums2.Length - 1])
		{
			median = FindMedianSortedArraysOrdered(nums2, nums1);
			foundMedian = true;
		}

		if (!foundMedian)
		{
			var num1Left = 0;
			var num2Left = 0;
			var num1Right = nums1.Length - 1;
			var num2Right = nums2.Length - 1;
			var smallest = 0;
			var largest = 0;
			
			while (num1Left <= num1Right || num2Left <= num2Right)
			{
				if(num1Left > num1Right)
				{
					smallest = nums2[num2Left];
					largest = nums2[num2Right];
					num2Left++;
					num2Right--;
					continue;
				}
				else if (num2Left > num2Right)
				{
					smallest = nums1[num1Left];
					largest = nums1[num1Right];
					num1Left++;
					num1Right--;
					continue;
				}
				if(nums1[num1Left] > nums2[num2Left])
				{
                    smallest = nums2[num2Left];
					num2Left++;
				}
				else
				{
					smallest = nums1[num1Left];
					num1Left++;
				}
				if (nums1[num1Right] > nums2[num2Right])
				{
					largest = nums1[num1Right];
					num1Right--;
				}
				else
				{
					largest = nums2[num2Right];
					num2Right--;
				}
			}
			median = (smallest + largest) / 2.0;
		}

		return median;
	}

	public double FindMedianSortedArraysOrdered(int[] nums1, int[] nums2)
	{
		var totalLength = nums1.Length + nums2.Length;

		if (nums1.Length > nums2.Length)
		{
			var rightIndex = totalLength / 2;
			left = nums1[(totalLength - 1) / 2];
			if (rightIndex == nums1.Length)
			{
				right = nums2[0];
			}
			else
			{
				right = nums1[rightIndex];
			}
		}
		else if (nums1.Length < nums2.Length)
		{
			left = nums2[(totalLength - 1) / 2 - nums1.Length];
			right = nums2[totalLength / 2 - nums1.Length];
		}
		else
		{
			left = nums1[nums1.Length - 1];
			right = nums2[0];
		}
		median = (left + right) / 2.0;

		return median;
	}
}