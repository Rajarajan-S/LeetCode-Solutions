# Write your MySQL query statement below
SELECT u.name, SUM(amount) AS balance FROM Transactions, Users u WHERE u.account = Transactions.account GROUP BY u.account HAVING balance > 10000;