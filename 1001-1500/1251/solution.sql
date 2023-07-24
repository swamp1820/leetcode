select p.product_id, ROUND(sum(u.units*p.price)*1./sum(u.units),2) as average_price
from Prices p
left join UnitsSold u on p.product_id=u.product_id and u.purchase_date BETWEEN p.start_date AND p.end_date     
GROUP BY p.product_id