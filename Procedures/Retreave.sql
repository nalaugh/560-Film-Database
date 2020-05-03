--Stored procedure that retrieves data met by the condition

DROP PROCEDURE if Exists RetrievePersons; 
DROP PROCEDURE if Exists RetrieveProduction;
DROP PROCEDURE if Exists RetrieveProductionByName;
DROP PROCEDURE if EXists RetrieveOscars;
DROP PROCEDURE if Exists RetrieveMovie; 
DROP PROCEDURE if Exists RetrieveMoviePerson;
DROP PROCEDURE if Exists RetrieveMovieAwardsWon;
DROP PROCEDURE if Exists RetrieveIndividualAwardsWon;
DROP PROCEDURE if Exists RetrieveSalesbyMovie;
DROP PROCEDURE if EXists RetrieveMovieByDate;
DROP PROCEDURE if Exists RetrievePeople;
DROP PROCEDURE if Exists RetrieveMovieByProduction;

go

CREATE OR ALTER PROCEDURE RetrievePersons
AS

SELECT *
FROM Film.Person 
GO

CREATE OR ALTER PROCEDURE RetrieveProduction
AS

SELECT*
FROM Film.ProductionHouse 
GO


CREATE OR ALTER PROCEDURE RetrieveProductionDeleated
AS
SELECT*
FROM Film.ProductionHouse 

Go


CREATE OR ALTER PROCEDURE RetrieveMoviePerson
AS

SELECT *
FROM Film.MoviePerson 
GO

CREATE OR ALTER PROCEDURE RetrieveMovie
AS

SELECT*
FROM Film.Movie 
GO

CREATE OR ALTER PROCEDURE RetrieveIndividualAwardsWon
AS

SELECT *
FROM Film.IndividualAwardsWon 
GO

CREATE OR ALTER PROCEDURE RetrieveMovieAwardsWon
AS

SELECT *
FROM Film.MovieAwardsWon 
GO

CREATE OR ALTER PROCEDURE RetrieveSales
AS

SELECT *
FROM Film.Sales 
GO

CREATE OR ALTER PROCEDURE RetrieveOscars
AS

SELECT *
FROM Film.Oscars 
GO

-------Retreveing an item not--------

CREATE OR ALTER PROCEDURE RetrieveMovieByProduction
   @ProductionId INT
AS

SELECT p.MovieId, p.MovieName,p.ReleaseDate
FROM Film.Movie P
WHERE P.ProductionId = @ProductionId;
GO


CREATE OR ALTER PROCEDURE RetrieveProductionByName
   @Name NVARCHAR(32)
AS

SELECT p.ProductionId, p.ProductionName,p.[Location]
FROM Film.ProductionHouse P
WHERE P.ProductionName = @Name;
GO

CREATE OR ALTER PROCEDURE RetrieveMovieByDate
   @RealeaseDate Date
AS

SELECT p.MovieId, p.MovieName,p.ProductionId
FROM Film.Movie P
WHERE p.ReleaseDate = @RealeaseDate;
GO

CREATE OR ALTER PROCEDURE RetrieveMoviePersonbyPerson
   @PersonId INT
AS

SELECT p.MovieId, p.MoviePersonId, p.[Role]
FROM Film.MoviePerson P
WHERE p.PersonId = @PersonId;
GO

CREATE OR ALTER PROCEDURE RetrieveSalesbyMovie
   @MovieId INT
AS

SELECT p.DomesticSales, p.ForeignSales
FROM Film.Sales p
WHERE p.MovieId = @MovieId;
GO





CREATE OR ALTER PROCEDURE RetrieveOscarsIndividual
   @IndividualAwardsWonId INT
AS

SELECT p.IndividualAwardsWonId, p.MovieAwardsWonId, p.[Year]
FROM Film.Oscars p
WHERE p.IndividualAwardsWonId = @IndividualAwardsWonId;
GO

CREATE OR ALTER PROCEDURE RetrieveOscarsMovie
   @MovieAwardsWonId INT
AS

SELECT p.OscarsId, p.IndividualAwardsWonId, p.[Year]
FROM Film.Oscars p
WHERE p.MovieAwardsWonId = @MovieAwardsWonId;
GO

CREATE OR ALTER PROCEDURE RetrieveProductionDeleated
AS

SELECT *
FROM Film.ProductionHouse P;
GO

CREATE OR ALTER PROCEDURE RetrievePersonByName 
 @Name NVARCHAR(64)
AS
SELECT *
FROM Film.Person P
WHERE P.Name = @Name;
GO