SELECT DEPARTMENT_ID, ROUND(AVG(SALARY), 2)  AS 'AVERAGE SALARY'
FROM EMPLOYEES
GROUP BY DEPARTMENT_ID
ORDER BY DEPARTMENT_ID ASC