
-- Stored Procedure that delete the specified item by the condition 
Drop PROCEDURE if exists DeleteProduction;
Drop PROCEDURE if exists DeleteMovie;
Drop PROCEDURE if exists DeletePerson;
Drop PROCEDURE if exists DeleteSales;
Drop PROCEDURE if exists DeleteOscars;
Go

CREATE OR ALTER PROCEDURE DeleteProduction
	@Name Nvarchar(64)
as
Update Film.ProductionHouse
set IsDeleted = N'Deleted'
where ProductionName = @Name
Go

CREATE OR ALTER PROCEDURE DeleteMovie
	@Name Nvarchar(64)
as
Update Film.Movie
set IsDeleted = N'Deleted'
where MovieName = @Name

Go
CREATE OR ALTER PROCEDURE DeletePerson
	@Name Nvarchar(64)
as
Update Film.Person
set IsDeleted = N'Deleated'
where [Name] = @Name

Go
CREATE OR ALTER PROCEDURE DeleteOscars
	@Name Nvarchar(64)
as
Update Film.Oscars
set IsDeleted = N'Deleated'
where [Year] = @Name

Go
CREATE OR ALTER PROCEDURE DeleteSales
	@Name int
as
DELETE FROM FILM.Sales WHERE MovieId = @Name; 

