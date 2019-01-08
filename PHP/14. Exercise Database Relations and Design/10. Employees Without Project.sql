SELECT e.employee_id, e.first_name
FROM employees AS e
WHERE e.manager_id IS NULL
ORDER BY e.employee_id DESC
LIMIT 3