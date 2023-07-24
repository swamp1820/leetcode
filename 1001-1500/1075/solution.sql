select project_id, ROUND(AVG(e.experience_years*1.),2) as average_years
from Project p
left join Employee e on p.employee_id = e.employee_id
group by project_id