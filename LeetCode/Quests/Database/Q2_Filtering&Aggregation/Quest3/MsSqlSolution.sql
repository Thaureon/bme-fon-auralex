/* Write your T-SQL query statement below */
SELECT 
    FORMAT(t.trans_date, 'yyyy-MM') AS month,
    t.country,
    COUNT(t.amount) AS trans_count,
    COUNT(CASE WHEN t.state = 'approved' THEN t.amount ELSE NULL END) AS approved_count,
    SUM(t.amount) AS trans_total_amount,
    SUM(CASE WHEN t.state = 'approved' THEN t.amount ELSE 0 END) AS approved_total_amount
FROM Transactions t
GROUP BY FORMAT(t.trans_date, 'yyyy-MM'), t.country
