select w2.id
from weather w1
join weather w2 on w1.recordDate = DATEADD(dd,-1,w2.recordDate)
where w2.temperature> w1.temperature