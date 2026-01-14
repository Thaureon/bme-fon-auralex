# LeetCode SQL 1
## Quest 4
Find Customer Referee

## Thought Process
- Given 1 tables
- Find customers not refereed by Id 2
- Find customers not refereed by anyone
- Get rows where referee_id is null
- Get rows where referee_id is not 2
- This seems like testing multiple where statements with or

## Solutions
-  MS SQL Server
    - FileName: MsSqlSolution.sql
    - Notes:
        - Simple solution where you want 2 different where statements.

## Statistics
According to LeetCode Runtime Analysis.
- MS SQL Server
    - Runtime - 492 MS
