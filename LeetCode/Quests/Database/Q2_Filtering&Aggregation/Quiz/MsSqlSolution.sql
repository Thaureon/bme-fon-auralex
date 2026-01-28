/* Write your T-SQL query statement below */
SELECT p.product_name, SUM(o.unit) AS unit
FROM Products p
JOIN Orders o ON p.product_id = o.product_id
WHERE o.order_date BETWEEN '02-01-2020' AND '02-29-2020'
GROUP BY p.product_name
HAVING SUM(o.unit) >= 100