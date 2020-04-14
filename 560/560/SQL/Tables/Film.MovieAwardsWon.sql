IF OBJECT_ID(N'Film.MovieAwardsWon') IS NULL
BEGIN
	CREATE	TABLE Film.MovieAwardsWon
	(
		MovieAwardsWonId int NOT NULL IDENTITY(1,1),
		MovieId int NOT NUll,
		Category Nvarchar(64) not null,
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		CONSTRAINT [PK_Film_MovieAwardsWon_MovieAwardsWonId] PRIMARY KEY CLUSTERED
      (
         MovieAwardsWonId ASC
      ),

      CONSTRAINT FK_Film_MovieAwardsWon_Film_Movie FOREIGN KEY(MovieId)
      REFERENCES Film.Movie(MovieId)
	);
END; 

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Film.MovieAwardsWon')
         AND kc.[name] = N'UK_Film_MovieAwardsWon_MovieId_Category'
   )
BEGIN
   ALTER TABLE Film.MovieAwardsWon
   ADD CONSTRAINT [UK_Film_MoviePerson_MovieId_Role] UNIQUE NONCLUSTERED
   (
      MovieId,
      Category
   )
END;
/****************************
 * Foreign Keys Constraints
 ****************************/
IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Film.MovieAwardsWon')
         AND fk.referenced_object_id = OBJECT_ID(N'Film.Movie')
         AND fk.[name] = N'FK_Film_MovieAwardsWon_Film_Movie'
   )
BEGIN
   ALTER TABLE Film.MovieAwardsWon
   ADD CONSTRAINT [FK_Film_MovieAwardsWon_Film_Movie] FOREIGN KEY
   (
      MovieId
   )
   REFERENCES Film.Movie
   (
      MovieId
   );
END;
