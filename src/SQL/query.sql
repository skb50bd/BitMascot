SELECT name
FROM employees
WHERE id = (SELECT MAX(id) FROM employees); 

SELECT name
FROM employees
GROUP BY name
HAVING COUNT(*) > 1

SELECT name
FROM employees
GROUP BY name
HAVING COUNT(*) > 1
ORDER BY COUNT(*) DESC
LIMIT 1 