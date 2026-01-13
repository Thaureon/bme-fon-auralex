# LeetCode SQL 1
## Quest 2
Employees Earning More Than Their Managers

## Thought Process
- Given 1 tables, Employees return name
- We only care about 1 level of employee to manager
- Need to Join Employees table to itself on Id = managerId
- Only care about entries that have the employee salary greater than manager salary

## Solutions
-  MS SQL Server
    - FileName: MsSqlSolution.sql
    - Notes:
        - Solution was simple with constraints from above.
        - Missed name of column needing to be Employee on output.

## Statistics
According to LeetCode Runtime Analysis.
- MS SQL Server
    - Runtime - 395 MS
