# LeetCode Basic Bit Operations
## Quiz
Find The Original Array of Prefix Xor
- Input: int[] pref
- Output: int[]

## Thought Process
- given a final array that is XORed from each element to the next.
- We need to get the original XOR list.
- Can't this just be done with pref[i] ^ pref[i-1] = answer?
- The only catch would be if i is the first element.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - This just made me think of the following
            - we have the answer and one XOR value.
            - Isn't the inverse just XORing the answer and the one value?
        - This could have been "simpler" if I just used the list that was sent in, but I don't like editting that list unless necessary.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 4 MS
    - Memory - 79.32 MB
