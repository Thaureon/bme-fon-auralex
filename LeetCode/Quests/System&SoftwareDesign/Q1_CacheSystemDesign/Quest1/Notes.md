# LeetCode Cache System Design
## Quest 1
LRU Cache

## Thought Process
- We are given a cache of x size, and only need to keep it at that size.
- If it grows larger that the capacity we need to removed the least used value.
- When getting the values we either return the record or return -1.
- When putting the record we need to see if the limit would be reached.
    - If it hasn't been reached then add the new record like normal, if it has been reached, then remove the lowest value.
    - If it has been reached, then we need to remove the the value with the least used value, then add the new one.
    - If the value exists, we update it with the new value
- Get can be O(1) if we use a dictionary
- Getting the value with the lowest rating is difficult because you need to know what the rating is for every record.
- This might not be the hardest part if we just ...
- Gonna start with a dictionary to store the data and get the get/put basics working.
- What if I do linkedList nodes inside of a Dictionary
    - This will have the length be easy to get since they are passing the key and we can always know which node is the first node IE the least used node.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - With needing the get and put to be O(1) this eliminated a lot of different types of storage including basic lists
        - With the need to know what was used the least recent, this eliminated more types of storage like dictionaries and sets.
        - This meant that the only type would be a mix of them.
        - Having a dictionary handle the O(1) speed for get and put allowed you to keep the correct speed for get and set but deleting wouldn't be able to be handled that way.
        - By adding a doubly linked list this allowed you to know what the oldest and newest record was so you could just remove the oldest and move the latest record to the end.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 44 MS
    - Memory - 174.71 MB
