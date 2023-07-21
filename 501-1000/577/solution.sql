SELECT name, bonus
FROM employee e
LEFT JOIN bonus b on e.empId = b.empId
WHERE b.bonus is NULL or b.bonus<1000