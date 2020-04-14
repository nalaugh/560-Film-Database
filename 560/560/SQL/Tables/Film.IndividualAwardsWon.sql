IF OBJECT_ID(N'Film.IndividualAwardsWon') IS NULL
BEGIN
	CREATE	TABLE Film.IndividualAwardsWon
	(
		IndividualAwardsWonId int NOT NULL IDENTITY(1,1),
		MoviePersonId int NOT NUll,
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		CONSTRAINT [PK_Film_IndividualAwardsWon_IndividualAwardsWonId] PRIMARY KEY CLUSTERED
      (
         IndividualAwardsWonId ASC
      ),

      CONSTRAINT FK_Film_IndividualAwardsWon_Film_MoviePerson FOREIGN KEY(MoviePersonId)
      REFERENCES Film.MoviePerson(MoviePersonId)
	);
END; 

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Film.IndividualAwardsWon')
         AND kc.[name] = N'UK_Film_IndividualAwardsWon_MoviePersonId_Category'
   )
BEGIN
   ALTER TABLE Film.IndividualAwardsWon
   ADD CONSTRAINT [UK_Film_IndividualAwardsWon_MoviePersonId_Category] UNIQUE NONCLUSTERED
   (
      MoviePersonId
   )
END;
/****************************
 * Foreign Keys Constraints
 ****************************/
IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Film.IndividualAwardsWon')
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
