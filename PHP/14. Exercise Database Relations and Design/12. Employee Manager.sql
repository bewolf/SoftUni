SELECT e.employee_id, e.first_name, e.manager_id, a.first_name
FROM employees AS e
JOIN employees AS a
ON e.manager_id = a.employee_id
WHERE e.manager_id = 3 OR e.manager_id = 7
ORDER BY e.first_name ASC