SELECT count(*) as country_count FROM countries as c
LEFT JOIN mountains_countries m
ON c.country_code = m.country_code
WHERE m.country_code IS NULL