IF OBJECT_ID(N'Film.ProductionHouse') IS NULL
BEGIN
	CREATE	TABLE Film.ProductionHouse
	(
		ProductionId int NOT NULL IDENTITY(1,1),
		ProductionName Nvarchar(64) not null,
		[Location] Nvarchar(64) not null,
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		CONSTRAINT [PK_Film_ProductionHouse_ProductionId] PRIMARY KEY CLUSTERED
      (
         ProductionId ASC
      )

	);
END; 