# LeetCode SQL 1
## Quiz
Employees Whose Manager Left the Company

## Thought Process
- Given 1 tables
- Find Employees that don't have a manager_id
- Find Employees where the manager_id does not link to a manager
- To get list of Employees without manager, need to left join and only pull null managers
- only need employee_id
- Missed requirement of less than 30k salary, this is strictly less than 30k
- Missed ordering by employee_id

## Solutions
-  MS SQL Server
    - FileName: MsSqlSolution.sql
    - Notes:
        - Missing some basic requirements hurts final solution.  Full details need to be read before making solution.
        - Iteration of solution to get initial data working is find tho.

## Statistics
According to LeetCode Runtime Analysis.
- MS SQL Server
    - Runtime - 374 MS
