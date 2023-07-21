select s.student_id, student_name, sj.subject_name,  count(e.subject_name) as attended_exams 
from students s
CROSS JOIN subjects sj
left join examinations e on s.student_id = e.student_id and sj.subject_name = e.subject_name 
GROUP BY s.student_id, student_name, sj.subject_name
order by s.student_id, student_name