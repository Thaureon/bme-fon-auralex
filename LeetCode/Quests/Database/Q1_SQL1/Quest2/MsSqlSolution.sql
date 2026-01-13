/* Write your T-SQL query statement below */
SELECT e.name as Employee
FROM Employee e
LEFT JOIN Employee m ON m.id = e.managerId
WHERE e.salary > m.salary