---Show total box office of all movies
Select M.MovieName, P.ProductionName, Sum(cast(s.ForeignSales as BigInt))  + Sum(cast(s.DomesticSales as BigInt))As WoldWide
From FILM.Movie M
inner join FILM.Sales s on s.MovieId = M.MovieId
inner join FILM.ProductionHouse p on p.ProductionId = m.ProductionId
group by M.MovieName, P.ProductionName, s.ForeignSales, S.DomesticSales
order by WoldWide;


---Show directors from Disney

Select p.[Name], ph.ProductionName, mp.[Role], M.MovieName
From Film.MoviePerson Mp
inner join Film.Person p on Mp.PersonId = p.PersonId
inner join FILM.Movie m on m.MovieId = mp.MovieId
inner join FILM.ProductionHouse ph on ph.ProductionId = m.ProductionId and ph.ProductionName = 'Walt Disney Studios Motion Pictures'


---Best picture director
select p.[Name],m.MovieName
from FILM.Oscars o
inner join FILM.MovieAwardsWon mw on mw.MovieAwardsWonId = o.MovieAwardsWonId and mw.Category = 'Best Picture'
inner join FILM.Movie m on m.MovieId = mw.MovieId
inner join FILM.MoviePerson mp on mp.MovieId = m.MovieId
inner join FILM.Person p on p.PersonId = mp.PersonId

---lead actor
select p.[Name],mp.Role
from FILM.Oscars o
inner join FILM.IndividualAwardsWon mw on mw.IndividualAwardsWonId = o.IndividualAwardsWonId
inner join FILM.MoviePerson mp on mp.MoviePersonId = mw.MoviePersonId and mp.Role = N'Lead Actor'
inner join FILM.Person p on p.PersonId = mp.PersonId

----Production house that have wons

select p.ProductionName,  count(o.MovieAwardsWonId)
from FILM.Oscars O
inner join Film.MovieAwardsWon mw on mw.MovieAwardsWonId = o.MovieAwardsWonId
inner join FILM.Movie m on m.MovieId = mw.MovieId
inner join FILM.ProductionHouse p on p.ProductionId = m.ProductionId
group by P.ProductionName, o.MovieAwardsWonId
order by count(o.MovieAwardsWonId)  asc

----TOP DOMSETIC

select top 5 s.DomesticSales, M.MovieName
from FILM.Movie m
inner join FILM.ProductionHouse ph on ph.ProductionId = m.ProductionId
inner join FILM.Sales s on s.MovieId = m.MovieId
order by s.DomesticSales DESC



---checks to see if thier a new movie or out of theaters

Select M.MovieName, m.ReleaseDate,
case
	when CONVERT(datetime, m.ReleaseDate) >='2019-10-01' then N'New Movie'
	else N'out of thaters'
end as N'MovieStatus'
from Film.Movie M

---type of movie
Select M.MovieName, m.ReleaseDate,
case
	when Month(CONVERT(datetime, m.ReleaseDate))  BETWEEN '01'and '02' then N'Winter movie'
	when Month(CONVERT(datetime, m.ReleaseDate))  BETWEEN '03'and '04' then N'Spring movie'
	when Month(CONVERT(datetime, m.ReleaseDate))  BETWEEN '05'and '08' then N'Summer movie'
	when Month(CONVERT(datetime, m.ReleaseDate))  BETWEEN '09'and '10' then N'Fall movie'
	when MOnth(CONVERT(datetime, m.ReleaseDate))  BETWEEN '11'and '12' then N'Winter movie'
	else N'not yet out'
end as N'time of year'
from Film.Movie M

---Getting the younger people in the film industry
Declare
@bithdate DATE = '1970-01-01';
select p.[Name], P.DOB
from Film.Person p
where CONVERT(VARCHAR, p.DOB, 110)> @bithdate

----getting the directors
Declare
@Role NVARCHAR = N'Director';
select p.[Name]
from FILM.MoviePerson mp
inner join Film.Person p on p.PersonId = mp.PersonId
where mp.Role> @Role


---Disney Holiday movies
Select M.MovieName, m.ProductionId
From FILM.Movie m
inner join FILM.Sales s on s.MovieId = m.MovieId
where  CONVERT(VARCHAR, m.ReleaseDate, 110)  BETWEEN '2019-11-01' AND '2019-12-31' and m.ProductionId in
(
select ph.ProductionId
From Film.ProductionHouse ph
where ph.ProductionName = 'Walt Disney Studios Motion Pictures'
)

---production house by year total
With YtdTotal(ProductionId, SalesTotal) as
(
	select m.ProductionId, (Sum(cast(s.ForeignSales as BigInt))  + Sum(cast(s.DomesticSales as BigInt)))as SalesTotal
	from Film.Sales s 
	inner join FILM.Movie m on m.MovieId = s.MovieId
	group by m.ProductionId, s.ForeignSales, s.DomesticSales
)
select  o.ProductionId,ph.ProductionName, sum(o.SalesTotal)as YearTotal
from YtdTotal o
join FILM.ProductionHouse ph on ph.ProductionId = o.ProductionId
group by o.ProductionId, ph.ProductionName






