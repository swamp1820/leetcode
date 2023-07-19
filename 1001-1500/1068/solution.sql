select p.product_name, year, price
from sales s
left join Product p on s.product_id=p.product_id