# LeetCode Data Stream Processing
## Quest 2
Steam of Characters

## Thought Process
- We are given a list of words
- After that we are given a stream of characters
- We need to see if any of the words are made from the stream character
- I am initially thinking we need to keep a record of the words and their position for all valid checks of words.
- We verify if any word in our records have their next letter be that value and if it doesn't then we remove it from the record.
- If it does we increment the record and move to the record.
- After that we need to see if any word reached their length limit.
- If any did we remove them from the list and return true.
- One thing that I did not consider is that all letters sent in are lowercase
- All words are entirely lowercase as well.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - This solution is apparently slow
        - This seemed like one of the most logical ways to handle this problem.
        - There are some shorter ways of checking.
        - Getting all of the valid characters and if the letter is not in that list clear the holding list and return false immediately
        - This will increase the spead for letters not there, but will require the same process for a list of letters in different words.
        - Another solution that appeared was the TrieNode
        - While this can be a valid solution the issue I see with it is that you have 2000 words with lengths up to 200 letters


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 1676 MS
    - Memory - 120.27 MB
