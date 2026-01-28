# LeetCode Filtering & Aggregation
## Quiz
List the Products Ordered in a Period

## Thought Process
- 2 tables Products/Orders
- Return product_name and number of units
- Products has the product_name
- Orders has the number of units
- need to sum based on the number of products
- only include the products that have a sum of at least 100
- JOIN the 2 tables on product_id
- HAVING SUM >= 100
- Missed that we only want orders in Feb of 2020
- WHERE order_date BETWEEN feb 1st and feb 28th 

## Solutions
-  MS SQL Server
    - FileName: MsSqlSolution.sql
    - Notes:
        - Another solution that might have been easier would be to use a subquery to limit the info needed from the orders in the first place.
        - This also helps to eliminate the issue that might arrise when dealing with products that have the same name.

## Statistics
According to LeetCode Runtime Analysis.
- MS SQL Server
    - Runtime - 403 MS
