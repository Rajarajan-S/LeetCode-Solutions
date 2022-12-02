# Write your MySQL query statement below
WITH CTE AS 

(

    SELECT ID, VISIT_DATE, PEOPLE, (ID - ROW_NUMBER() OVER()) AS TID

    FROM STADIUM

    WHERE PEOPLE >= 100

)

SELECT 

ID, 

VISIT_DATE,

PEOPLE

FROM CTE  

WHERE TID IN (

            SELECT 

            TID

            FROM CTE

            GROUP BY TID

            HAVING COUNT(*) >= 3

)