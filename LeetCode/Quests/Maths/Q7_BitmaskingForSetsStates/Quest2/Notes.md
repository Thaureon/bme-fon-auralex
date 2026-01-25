# LeetCode Bitmasking for Sets/States
## Quest 2
Number of Digit One
- Input: int n
- Output: int

## Thought Process
- We are given n and have to count the number of 1s that appear in all digits from n to 0
- for the 1s place we can take 1 * tens^
- for the 10s place we can take 10 * hundreds^
- this continues for each of the differnt positions.
- The only piece that I need to worry about is 156.
    - This would start by giving me 16 1s, 20 tens, and 100 hundreds.
    - We only need 56 hundres though, so I could do hundreds position - 1 + 56? but that wouldn't happen for 256, that would just be 100.
    - to get 1s it will be ((n - 1) / 10) + 1 -> this gives me 10 - 1 / 10 => 0 as decimals are removed.
        - this will also give me ((46 - 1) / 10) + 1 => (45/10)+1 => 4+1 => 5, so 5 instances of 1s in the ones place have occured.
    - Similar logic for 10s would be ((n - 10) / 100) + 10
        - for 523 => ((523 - 10) / 100) + 10 =? (513 / 10) + 10 => 51 + 10 => 61
        - digitsLeft * position IE 600 => 6 * 10 to give 
        - digitsLeft = (n - 20) / 100
        - digitsLeft = (n - 200) / 1000
- I feel like there is a better way to do this.
- What if I start from the left?


## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Thinking through this with the math made it easier after some testing.
        - There were a couple of places that I did miss when doing calculations manually.
        - Some edge cases that I missed with initial design is when n equals my multiplier.
        - This was fixed and didn't change any of the logic inside the loop.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 0 MS
    - Memory - 29.14 MB
