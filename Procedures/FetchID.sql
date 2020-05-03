--Stored procedure that fetches data based on the condition
CREATE OR ALTER PROCEDURE FetchPerson
   @PersonId INT
AS

SELECT P.[Name],P.DOB,P.DeathDate
FROM FILM.Person p
WHERE P.PersonId = @PersonId;
GO


CREATE OR ALTER PROCEDURE FetchProductionHouse
   @ProductionId INT
AS

SELECT P.ProductionName, P.[Location]
FROM FILM.ProductionHouse P
WHERE P.ProductionId = @ProductionId;
GO

CREATE OR ALTER PROCEDURE FetchMovie
   @MovieId INT
AS

SELECT M.MovieName, M.ProductionId,M.ReleaseDate
FROM FILM.Movie M
WHERE M.MovieId = @MovieId;
GO



CREATE OR ALTER PROCEDURE FetchMoviePerson
   @MoviePersonId INT
AS

SELECT M.PersonId, M.[Role], M.MovieId
FROM FILM.MoviePerson M
WHERE M.MoviePersonId = @MoviePersonId;
GO

CREATE OR ALTER PROCEDURE FetchMovieAwardsWon
   @MovieAwardsWon INT
AS

SELECT M.MovieId, M.Category
FROM FILM.MovieAwardsWon M
WHERE M.MovieAwardsWonId = @MovieAwardsWon;
GO

CREATE OR ALTER PROCEDURE FetchIndividualAwardsWon	
   @IndividualAwardsWonId INT
AS

SELECT I.MoviePersonId
FROM FILM.IndividualAwardsWon I
WHERE I.IndividualAwardsWonId = @IndividualAwardsWonId;
GO

CREATE OR ALTER PROCEDURE FetchOscars	
   @OscarsId INT
AS

SELECT O.IndividualAwardsWonId, O.MovieAwardsWonId, O.[Year]
FROM FILM.Oscars O
WHERE O.OscarsId = @OscarsId;
GO