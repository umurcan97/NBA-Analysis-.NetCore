select 
gp.GameNo,
gp.HomeTeam,
gp.AwayTeam,
gp.HomePoints,
gp.AwayPoints
from GamePredictions gp inner join GameTime gt on gp.GameNo=gt.GameNo where gt.GameDate>'2022-03-30 01:00:00.0000000'
order by gt.GameDate