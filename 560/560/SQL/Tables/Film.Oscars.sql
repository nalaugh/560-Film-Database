-----Needs to be worked on
IF OBJECT_ID(N'Film.Oscars') IS NULL
BEGIN
	CREATE	TABLE Film.Oscars
	(
		OscarsId int NOT NULL IDENTITY(1,1),
		IndividualAwardsWonId int NOT NUll,
        MovieAwardsWonId int NOT NUll,
        [Year] Date not null,
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		CONSTRAINT [PK_Film_Oscars_OscarsId] PRIMARY KEY CLUSTERED
      (
         OscarsId ASC
      ),

      CONSTRAINT FK_Film_IndividualAwardsWon_Film_MoviePerson FOREIGN KEY(MoviePersonId)
      REFERENCES Film.MoviePerson(MoviePersonId)
	);
END; 

/****************************
 * Foreign Keys Constraints
 ****************************/
IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Film.Oscars')
         AND fk.referenced_object_id = OBJECT_ID(N'Film.MoviePerson')
         AND fk.[name] = N'FK_Film_IndividualAwardsWon_Film_MoviePerson'
   )
BEGIN
   ALTER TABLE Film.IndividualAwardsWon
   ADD CONSTRAINT [FK_Film_IndividualAwardsWon_Film_MoviePerson] FOREIGN KEY
   (
      MoviePersonId
   )
   REFERENCES Film.Movie
   (
      MoviePersonId
   );
END;
