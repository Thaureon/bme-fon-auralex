/* Write your T-SQL query statement below */

SELECT c.id, c.movie, c.description, c.rating
FROM Cinema c
WHERE c.description != 'boring'
AND c.id % 2 = 1
ORDER BY rating DESC