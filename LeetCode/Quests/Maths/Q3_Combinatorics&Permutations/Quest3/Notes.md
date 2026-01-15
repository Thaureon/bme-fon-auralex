# LeetCode Combinatorics & Permutations
## Quest 3
Number of Ways to Rearrange Sticks With K Sticks Visible
- Input: int n, int k
- Output: int

## Thought Process
- From initial look this looks like a skyscrapper situation from soduku.
- Going from left to right we need to know how many situations would give would seeing k sticks in length of n give.
- if n == k, then we only have 1 order.
- with k == 1, the first digit has to be the highest, but nothing else matters.
- with n=10 & k=5, 10 has to be in pos 5-10.
- Total permutations to left * permutations to right for each of those positions.
- Right permutations is total number of permutations those digits, but this isn't completely right since we don't know what digits exist there.
- I want the correct calculation to handle all cases including n=k.
- Going from k to n n = 5, k = 3
    - at k permCount = permLeft(count)(1,2,3,4) * permRight(remaining)(1,2)
    - at k + 1 permCount = permLeft(1,2,3,4) * permRight(1)
        - permLeft needs to get highest in both 2nd pos and 3rd pos
    - at k = n permCount = permLeft(1,2,3,4)
- This can sort of be done through recursion
- Start with total possible perms
    - 5 gives 120 as this is just 5! = 5*4*3*2*1
- Easier way may be this
    - permRight = total possible from all digits.
    - permLeft = total possible from given digits.
    - total = permRight * permLeft
    - This allows you to only care about the largest value on left not what that value is.
    - for n=20 and k= 11, at pos 11, you will have 10 digits in increasing order, you don't care what those digits are if you have the right side already selecting it's digits.
    - We care about all perms from k to n  
    - This is sort of working, but something feels off that I can't quite figure out.


## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - 


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 4 MS
    - Memory - 36.31 MB
