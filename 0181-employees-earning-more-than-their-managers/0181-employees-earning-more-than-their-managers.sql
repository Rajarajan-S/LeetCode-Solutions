# Write your MySQL query statement below
SELECT E2.name AS Employee FROM Employee E1 INNER JOIN Employee E2 ON E1.id = E2.managerId
WHERE E1.salary < E2.salary
