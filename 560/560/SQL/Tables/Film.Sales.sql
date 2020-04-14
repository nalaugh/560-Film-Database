IF OBJECT_ID(N'Film.Sales') IS NULL
BEGIN
	CREATE	TABLE Film.Sales
	(
		MovieId int NOT NULL,
		DomesticSales int,--may not be released in the USA
		ForeignSales int,--may not be released outside of the USA
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		CONSTRAINT [PK_Film_Sales_MovieId] PRIMARY KEY CLUSTERED
      (
         ProductionId ASC
      ),
	  CONSTRAINT FK_Film_Sales_Film_Movie FOREIGN KEY(MovieId)
      REFERENCES Film.Movie(MovieId),

	);
END; 