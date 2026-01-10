# LeetCode Arithmetic & Basic Reasoning
## Quest 3
Palindrome Number
- Input: int x
- Output: bool

## Thought Process
- 3 different types of inputs can occur
    - positive even length
    - positive odd length
    - negative
- Negative numbers always return false as negative sign would have to exist at the end
- There are 2 possible solutions
    - build up second int from first using /10 and * 10
    - destroy int from both sides
- For building up second int we can remove the last digit from the first int and add it to the end of the second int then shift both inward.  If the final value of the second int matches the first int then it would be valid
- For each number we can remove the value from the front and back at the same time 121 -1 and -100.  This would require the final number to equal 0 or the value is not a palindrome
- I want to try the second one but don't know a good way to get the length without converting to string.

## Solutions
This problem was done before in LeetCode/Problems/Problem9, but trying to solve it using only math.
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Only issue with the second solution provided was determining the length of the input without converting it to string
        - Math.Log helped to get that value as that will get the number of zeros and adding one will give you the length
        - With this the solution was just removing the last digit from the front and back and checking if the final value was 0
        - One issue that arrose is with 213, this dropped the final value below zero, and this was fixed by adding a simple check to see if the value dropped below zero and just failing it.
        - This solution is slower than my original C# solution, but avoids converting the input into a string.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 3 MS
    - Memory - 34.62 MB
