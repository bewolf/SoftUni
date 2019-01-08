SELECT count(*)
FROM products AS p

RIGHT JOIN categories AS c
ON p.category_id = c.id
WHERE c.name = 'appetizers' AND price > 8