select * from dbo.Persons

select * from dbo.Persons
where Gender = 'M'

select * from dbo.Persons
where Age > 18

select * from dbo.Persons
where Address IS NULL

update dbo.Persons
set Age = Age +1  

update dbo.Persons
set Age = 18
where Gender = 'F'

update dbo.Persons
set Age = 21
where id = 1

update dbo.Persons
set Age = 30
where FirstName = 'Andriy'

update dbo.Persons
set Age = 25
where LastName = 'Rudakov'

update dbo.Persons
set Age = 25
where Age = 2

update dbo.Persons
set Address = 'Symerenko 7-a'
where id = 1

update dbo.Persons
set Address = 'Saksahanskogo 20'
where FirstName = 'Olena'

update dbo.Persons
set Address = 'Bulgakova 5-b'
where LastName = 'Mykytenko'

delete from dbo.Persons
where Address IS NULL

select count(*) from dbo.Persons 

select Age, count(*) as count
from dbo.Persons
group by Age