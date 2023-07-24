select *
from cinema c
where description<>'boring' and id%2!=0
order by rating desc
