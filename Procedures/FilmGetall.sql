-- The procedure below gets the desired output from the condition
CREATE OR ALTER PROCEDURE GetPersonName
  @Name NVARCHAR(64)
AS

SELECT *
FROM Film.Person P
WHERE P.[Name] = @Name;
GO

CREATE OR ALTER PROCEDURE GetPersonDOB
  @DOB Date
AS

SELECT P.PersonId, P.DeathDate, P.DOB
FROM Film.Person P
WHERE P.DOB = @DOB;
GO

CREATE OR ALTER PROCEDURE GetPersonDOD
  @DeathDate Date
AS

SELECT P.PersonId, P.DeathDate, P.DOB
FROM Film.Person P
WHERE P.DeathDate = @DeathDate;
GO

CREATE OR ALTER PROCEDURE  GetProductionHouseName
	@ProductionName Nvarchar(64)
AS

SELECT p.[Location], P.ProductionId
FROM Film.ProductionHouse p
WHERE P.ProductionName = @ProductionName
GO

CREATE OR ALTER PROCEDURE GetProductionHouseLocation
	@Location Nvarchar(64)
AS

SELECT p.ProductionName, P.ProductionId
FROM Film.ProductionHouse p
WHERE P.[Location] = @Location
GO

CREATE OR ALTER PROCEDURE GetMovieName
	@MovieName Nvarchar(64)
AS

SELECT M.MovieId, M.ProductionId, M.ReleaseDate
FROM Film.Movie M
WHERE M.MovieName = @MovieName
GO

CREATE OR ALTER PROCEDURE GetMovieReleaseDate
	@ReleaseDate Date
AS

SELECT M.MovieId, M.ProductionId, M.MovieName
FROM Film.Movie M
WHERE M.ReleaseDate = @ReleaseDate
GO

CREATE OR ALTER PROCEDURE GetMoviePersonRole
	@Role Nvarchar(64)
AS

SELECT p.PersonId, p.MovieId, p.MoviePersonId
FROM Film.MoviePerson P
WHERE p.[Role] = @Role
GO

CREATE OR ALTER PROCEDURE GetMovieAwardsWon
	@Category Nvarchar(64)
AS

SELECT M.MovieId, M.MovieAwardsWonId
FROM Film.MovieAwardsWon M
WHERE M.Category = @Category
GO


CREATE OR ALTER PROCEDURE OscarsYear
	@Year Date
AS

SELECT O.IndividualAwardsWonId, O.MovieAwardsWonId, O.OscarsId
FROM Film.Oscars O
WHERE O.[Year] = @Year
GO