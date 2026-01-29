# LeetCode Data Stream Processing
## Quest 1
Kth Largest Element in a Stream

## Thought Process
- Need to keep the kth largest item in the list.
- This might be done using a binary tree with the kth element being the root.
- This tree would always have k items on the right side and only need to be "rebalanced" if another item was added there.
- Lets try this approach and see what happens.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - While a tree storage does work, I realized that you didn't need to care about values below your root after you have the needed count above that value.
        - This would get rid of unnecessary adds and you could just return the "root" value.
        - After that you would only add new nodes if they are needed and then shift everything down.
        - While this can be done with a list or something similar, a tree helped to limit the downward values.
        - The issue with the tree is that it is a bit complex
        - This was supposed to be and "easy" problem, but I made it significantly more complex than it needed to be.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 900 MS
    - Memory - 71.70 MB
