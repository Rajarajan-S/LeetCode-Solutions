# Write your MySQL query statement below
SELECT d.name AS Department, e.Employee, e.Salary

FROM Department d

LEFT JOIN (

        SELECT 

            departmentId, 

            salary AS Salary,

            name AS Employee,

            DENSE_RANK() OVER (PARTITION BY departmentId ORDER BY salary DESC) AS 'salary_rank'

        FROM Employee) e

ON d.id = e.departmentId

WHERE salary_rank = 1