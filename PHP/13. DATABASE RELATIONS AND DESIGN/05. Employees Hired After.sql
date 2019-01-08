SELECT e.first_name, e.last_name, e.hire_date , d.name
FROM employees as e
INNER JOIN departments as d
ON e.department_id = d.department_id
WHERE d.name = 'Finance' OR d.name= 'Sales'
AND e.hire_date > '1999-01-01'
ORDER BY e.hire_date ASC