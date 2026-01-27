# LeetCode Filtering & Aggregation
## Quest 3
Monthly Transactions I

## Thought Process
- Group each month and country together
- transaction count and their total
- approved transaction count and their total
- This one is a bit difficult.
- trans_count/trans_total_amount is just grouping month/country
- approved_count/approved_total_amount is the same group but filtered to only have approved records.
    - I'm not sure how to do this without different subqueries
- Month can be gotten by just pulling the year/month from the date 

## Solutions
-  MS SQL Server
    - FileName: MsSqlSolution.sql
    - Notes:
        - Something I did not know is having case statements inside of counts and sum
        - This is a simple way to limit the amount of joins that are needed.
        - Another way I was thinking was just to make a subquery with the limit of accepted values.
        - Other solutions handle the date differently by doing char comparison instead of date comparison.  This may be better, but will only handle this format.

## Statistics
According to LeetCode Runtime Analysis.
- MS SQL Server
    - Runtime - 1686 MS
