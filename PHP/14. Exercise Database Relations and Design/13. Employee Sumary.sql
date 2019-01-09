SELECT e.employee_id, CONCAT(e.first_name, ' ', e.last_name) AS employee_name,
a.first_name AS manager_name, d.name AS department_name
FROM employees AS e
JOIN employees AS a
ON e.manager_id = a.employee_id
JOIN departments as d
ON e.department_id= d.department_id
ORDER BY e.employee_id
LIMIT 5