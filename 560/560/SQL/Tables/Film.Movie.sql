IF OBJECT_ID(N'Film.Movie') IS NULL
BEGIN
	CREATE	TABLE Film.Movie
	(
		MovieId int NOT NULL IDENTITY(1,1),
		ProductionId int NOT NUll,
		MovieName Nvarchar(64) not null,
		ReleaseDate Date not null,--not sure if this is how you do it
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		CONSTRAINT [PK_Film_Movie_MovieId] PRIMARY KEY CLUSTERED
      (
         MovieId ASC
      ),
	  CONSTRAINT FK_Film_Movie_Film_ProductionHouse FOREIGN KEY(ProductionId)
      REFERENCES Film.ProductionHouse(ProductionId),

	);
END; 