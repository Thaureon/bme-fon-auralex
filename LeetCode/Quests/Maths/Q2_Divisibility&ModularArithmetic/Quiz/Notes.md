# LeetCode Divisbility & Modular Arithmetic
## Quiz
Simple Bank System
- Input: string[] transaction names, int[][] transactions
- Output: bool? []

## Thought Process
- 4 total methods need to be created
    - Bank setup.  This creates the bank with the account position and ammount.
    - Transfer.  This moves money from one account to another account
    - Deposit.  This adds money to the specified account.
    - Withdraw.  This tries to remove money from the specified account.
- Transfer, Deposit, and Withdraw fail if account does not exist.
- Transfer, Withdraw fail if ammount is more than in account.
- The flow of this is straight forward in a sense of only these situations need to be checked.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Implementations was simple except for desired accounts were not the same as added accounts.
        - Accounts being added were 0 based, but access to accounts was 1 based.
        - This required the shift from 1 based to 0 based for transfer, deposit, and withdraw.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 3 MS
    - Memory - 142.16 MB
