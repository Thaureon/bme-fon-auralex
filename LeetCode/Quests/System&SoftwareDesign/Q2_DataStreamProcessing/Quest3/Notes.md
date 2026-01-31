# LeetCode Data Stream Processing
## Quest 2
Data Stream as Disjoint Intervals

## Thought Process
- Only given positibe numbers to add
- We are to get the ranges that appear on the list, so adding 1,2, and 3 would have a range of 1-3.
- What happens when we get 6 twice.  
    - Will this never happen
    - will we skip that number
    - will that be added to another set
    - This looks like it is just ignored
- List of all range sets that we get has the max and min value.
- I care about the order, so something where I can find the location of each member from 1 - 10000
- I could do this with a pair of bool[] and some sort of ordered list.
    - the ordered list would only have the start points of each of the lists and the bool[] would hold if that value appeared.
    - The issue with the bool[] would be if we had 5000 in a row we would have to go over all of them with every iteration.
    - We would need something that condenses the list when we remove a group.
- A priorityqueue is nice, but we would have to clear and readd it every time.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - I feel my solution is a bit scuffed.
        - I don't know how I did this good.
        - I used a linked list to easily give me the range that appeared for each of the sets that appear.
        - The issue that I really ran into was what happens when you get multiple sets that would collapse into one together.  How would this be handled.
        - My solution was to merge to the right with the current value and then "redirect" the amount down until it was apart of the final set.
            - This allowed me to reduce the sets that would be in the final set to just what was needed.
            - This means that the "GetInterval" aspect would just be going over the intervals and returning the confirmed list of sets.
        - With this I needed a way to keep the final set of intervals clean which lead me to a "redirect" which would be pulling all of the sets together and down to the first set.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 3 MS
    - Memory - 47.87 MB
