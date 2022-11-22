# Write your MySQL query statement below
SELECT 
CASE
    WHEN id%2 = 1 AND id != (SELECT COUNT(id) FROM seat) THEN id+1
    WHEN id%2 = 0 THEN id-1
    ELSE id
END AS id, student
FROM seat 
ORDER BY id