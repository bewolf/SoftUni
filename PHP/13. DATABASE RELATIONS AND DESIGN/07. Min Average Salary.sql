SELECT AVG(salary) as min_average_salary FROM employees
GROUP BY DEPARTMENT_ID
ORDER BY min_average_salary
LIMIT 1