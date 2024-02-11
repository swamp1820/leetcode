

--select AVG(SUM(CASE when status='immediate' THEN 1 else 0 end)*100.0/COUNT(*)) as immediate_percentage 
--from (
-- select customer_id,
-- MIN(order_date)  OVER (PARTITION BY customer_id)  as minDate,
-- CASE when order_date=customer_pref_delivery_date THEN 'immediate' else 'scheduled' end as status
-- from delivery
-- group by customer_id,customer_pref_delivery_date, order_date
-- --) as s
--group by s.customer_id

-- select d.customer_id,
-- CASE when MIN(d.order_date)=customer_pref_delivery_date THEN 'immediate' else 'scheduled' end as status
-- from Delivery d       
-- group by d.customer_id,customer_pref_delivery_dateselect 
FORMAT(trans_date, 'yyyy-MM') as month,
country, 
COUNT(*) as trans_count,
SUM(CASE WHEN state = 'approved' THEN 1 ELSE 0 END) as approved_count,
SUM(amount) as trans_total_amount,
SUM(CASE WHEN state ='approved' THEN amount ELSE 0 END) as approved_total_amount
from transactions
GROUP BY FORMAT(trans_date, 'yyyy-MM'), country;