# LeetCode Cache System Design
## Quest 2
LFU Cache

## Thought Process
- My initial thought is to have a similar solution to hte LRU Cache, but alter it to handle frequency instead of recency.
- A dictionary with a doubly linked list will allow the same flow.
- The main change would be to add a frequency counter onto the node and switch two nodes if the frequency is greater or equal to the next node in line.
- The only issue I can see is if there are multiple nodes with the same frequency, what happens then?

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Having multiple linked lists together caused a bit more of a headache that I initially thought it would.
        - Having a generic linked list that I could just remove a single node or add a node to the end to would make this significantly easier.
        - The base logic was the same, but it needed the extra layer of linked list to make sure that the list of linked lists was able to keep its relation to each other.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 29 MS
    - Memory - 180.54 MB
