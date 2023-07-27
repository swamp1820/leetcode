select contest_id, ROUND(count(*)*100.0/(select count(*) from users),2) as percentage
from users u
left join register r on u.user_id=r.user_id
where contest_id is not null
group by contest_id
order by percentage desc, contest_id asc  