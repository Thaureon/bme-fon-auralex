# LeetCode Filtering & Aggregation
## Quest 1
Customer Placing the Largest Number of Orders

## Thought Process
- We need to get the customer that had made the most orders.
- We only care about the customer's number
- We can get this by using group by and order by with only grabbing the top row.

## Solutions
-  MS SQL Server
    - FileName: MsSqlSolution.sql
        - The initial thought process was right, but I missed the order by count of the group by instead of just the customer number.

## Statistics
According to LeetCode Runtime Analysis.
- MS SQL Server
    - Runtime - 502 MS
