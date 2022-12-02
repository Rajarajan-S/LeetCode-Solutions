# Write your MySQL query statement below
SELECT DISTINCT a.num AS ConsecutiveNums 

FROM Logs a 

JOIN Logs b ON a.id=b.id+1 AND a.num=b.num

JOIN Logs c ON a.id=c.id+2 AND a.num=c.num