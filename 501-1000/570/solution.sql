SELECT e2.name
from employee e1
left join employee e2 on e1.managerId=e2.id
where e2.name IS NOT NULL
group by e2.name,e2.id
having COUNT(*)>=5