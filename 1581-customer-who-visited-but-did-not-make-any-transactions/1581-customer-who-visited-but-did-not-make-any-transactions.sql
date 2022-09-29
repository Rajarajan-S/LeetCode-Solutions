# Write your MySQL query statement below
SELECT customer_id, COUNT(V.visit_id) AS count_no_trans FROM Visits V WHERE V.visit_id
 NOT IN (SELECT T.visit_id FROM Transactions T) GROUP BY customer_id;