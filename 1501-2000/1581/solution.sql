select v.customer_id, COUNT(*) as count_no_trans 
from Visits v
left join Transactions t on v.visit_id=t.visit_id
where t.amount is NULL
GROUP BY v.customer_id