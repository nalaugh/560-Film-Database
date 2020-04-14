IF OBJECT_ID(N'Film.MoviePerson') IS NULL
BEGIN
	CREATE	TABLE Film.MoviePerson
	(
		MoviePersonId int NOT NULL IDENTITY(1,1),
		PersonId int Not null,
		MovieId int not null,
		[Role] Nvarchar(64) not null,--ie director that way we can remove a table 
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		CONSTRAINT [PK_Film_MoviePerson_MoviePersonId] PRIMARY KEY CLUSTERED
      (
         MoviePersonId ASC
      ),
	  CONSTRAINT FK_Film_MoviePerson_Film_Person FOREIGN KEY(PersonId)
      REFERENCES Film.Person(PersonId),

      CONSTRAINT FK_Film_MoviePerson_Film_Movie FOREIGN KEY(MovieId)
      REFERENCES Film.Movie(MovieId)
	);
END; 

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Film.MoviePerson')
         AND kc.[name] = N'UK_Film_MoviePerson_MovieId_Role'
   )
BEGIN
   ALTER TABLE Person.PersonAddress
   ADD CONSTRAINT [UK_Film_MoviePerson_MovieId_Role] UNIQUE NONCLUSTERED
   (
      MovieId,
      [Role]
   )
END;
/****************************
 * Foreign Keys Constraints
 ****************************/
IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Film.MoviePerson')
         AND fk.referenced_object_id = OBJECT_ID(N'Film.Person')
         AND fk.[name] = N'FK_Film_MoviePerson_Film_Person'
   )
BEGIN
   ALTER TABLE Film.MoviePerson
   ADD CONSTRAINT [FK_Film_MoviePerson_Film_Person] FOREIGN KEY
   (
      PersonId
   )
   REFERENCES Film.Person
   (
      PersonId
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Film.MoviePerson')
         AND fk.referenced_object_id = OBJECT_ID(N'Film.Movie')
         AND fk.[name] = N'FK_Film_MoviePerson_Film_Movie'
   )
BEGIN
   ALTER TABLE Film.MoviePerson
   ADD CONSTRAINT [FK_Film_MoviePerson_Film_Movie] FOREIGN KEY
   (
      MovieId
   )
   REFERENCES Film.Movie
   (
      MovieId
   );
END;