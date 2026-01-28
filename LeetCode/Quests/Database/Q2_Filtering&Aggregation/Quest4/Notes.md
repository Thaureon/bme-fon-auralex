# LeetCode Filtering & Aggregation
## Quest 4
User Activity for the Past 30 Days I

## Thought Process
- Need to get user activity for the past 30 days ending on 2019/07/27 inclusively
- This can be done with DateAdd to make sure that it is accurate.
- We do not care about the type of activity, just if there is activity and how many users.
- This will be handled with the following WHERE to limit, GROUP BY to get the number of users.

## Solutions
-  MS SQL Server
    - FileName: MsSqlSolution.sql
    - Notes:
        - I ran into an issue with the term "inclusively" this is not the best wording as it can signify both sides being included.
        - This caused the data to be slightly off for records that would be on that day 30 days before the recommended end.

## Statistics
According to LeetCode Runtime Analysis.
- MS SQL Server
    - Runtime - 502 MS
