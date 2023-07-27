select query_name,
ROUND(AVG(q.rating*1./q.position),2) as quality,
ROUND((select count(*) from queries where q.query_name=query_name and rating<3)*100.0/(select count(*) from queries where q.query_name=query_name),2) as poor_query_percentage
from queries q
group by query_name