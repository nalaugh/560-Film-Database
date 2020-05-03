
--The procedures below create the procedures to add to the individual tables.
CREATE OR ALTER PROCEDURE AddPerson
		@Name NVARCHAR(32),
		@DOB NVarchar(64),
        @DeathDate NVarchar(64),
		@PersonId int OUTPUT
AS
INSERT Film.Person([Name], DOB, DeathDate)
VALUES(@Name, @DOB, @DeathDate);

SET @PersonId = SCOPE_IDENTITY();

GO

CREATE OR ALTER PROCEDURE  AddProductionHouse
		@ProductionName Nvarchar(64),
		@Location Nvarchar(64),
		@ProductionId int OUTPUT
AS
INSERT Film.ProductionHouse(ProductionName, Location)
VALUES(@ProductionName, @Location);

SET @ProductionId = SCOPE_IDENTITY();
GO


CREATE OR ALTER PROCEDURE GetProductionHouseName
	@ProductionName Nvarchar(64)
AS

SELECT P.ProductionId 
FROM Film.ProductionHouse p
WHERE P.ProductionName = @ProductionName
GO



CREATE OR ALTER PROCEDURE AddMovie
		@ProductionId int,
		@MovieName Nvarchar(64),
		@ReleaseDate Nvarchar(32),
		@MovieId int OUTPUT
AS
INSERT  Film.Movie(ProductionId, MovieName, ReleaseDate)
VALUES((SELECT @ProductionId From  film.ProductionHouse where Film.ProductionHouse.ProductionId = @ProductionId) , @MovieName,@ReleaseDate);

SET @MovieId = SCOPE_IDENTITY();

GO

CREATE OR ALTER PROCEDURE AddSales
		@MovieId int,
		@DomesticSales money,
		@ForeignSales money
AS
INSERT  Film.Sales(MovieId, DomesticSales, ForeignSales)
VALUES(@MovieId, @DomesticSales,@ForeignSales);

GO


CREATE OR ALTER PROCEDURE Film.CreateMoviePerson	
		@PersonId int,
		@MovieId int,
		@Role Nvarchar(64),
		@MoviePersonId int OUTPUT
AS
INSERT  Film.MoviePerson(PersonId, MovieId, [Role])
VALUES(@PersonId, @MovieId,@Role);

SET @MoviePersonId = SCOPE_IDENTITY();
GO

CREATE OR ALTER PROCEDURE Film.CreateMovieAwardsWon		
		@MovieId int,
		@Category Nvarchar(64),
		@MovieAwardsWonId int OUTPUT
AS
INSERT  Film.MovieAwardsWon(MovieId, Category)
VALUES(@MovieId, @Category);

SET @MovieAwardsWonId = SCOPE_IDENTITY();
GO

CREATE OR ALTER PROCEDURE Film.CreateIndividualAwardsWon			
		@MoviePersonId int,
		@IndividualAwardsWonId int OUTPUT
AS
INSERT  Film.IndividualAwardsWon(MoviePersonId)
VALUES(@MoviePersonId);

SET @IndividualAwardsWonId = SCOPE_IDENTITY();
GO

CREATE OR ALTER PROCEDURE Film.CreateOscars					
		@IndividualAwardsWonId int,
       @MovieAwardsWonId int,
        @Year Date,
		@OscarsId int OUTPUT
AS
INSERT  Film.Oscars(IndividualAwardsWonId, MovieAwardsWonId,[Year])
VALUES(@IndividualAwardsWonId,@MovieAwardsWonId,@Year);

SET @OscarsId = SCOPE_IDENTITY();
GO


