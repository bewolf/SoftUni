SELECT FIRST_NAME, LAST_NAME, T.NAME, A.ADDRESS_TEXT
FROM EMPLOYEES AS E

INNER JOIN TOWNS AS T
ON E.ADDRESS_ID = T.TOWN_ID

INNER JOIN ADDRESSES AS A
ON E.ADDRESS_ID = A.ADDRESS_ID

ORDER BY FIRST_NAME ASC
LIMIT 5