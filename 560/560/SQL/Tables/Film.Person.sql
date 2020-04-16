IF OBJECT_ID(N'Film.Person') IS NULL
BEGIN
	CREATE	TABLE Film.Person
	(
		PersonId int NOT NULL IDENTITY(1,1),
		[Name] Nvarchar(64) not null,
		DOB Date(64) not null,
        DeathDate Date,
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		CONSTRAINT [PK_Film_Person_PersonId] PRIMARY KEY CLUSTERED
      (
         PersonId ASC
      ),
	  	);
END; 

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Film.Person')
         AND kc.[name] = N'UK_Film_Person_Name'
   )
BEGIN
   ALTER TABLE Film.Person
   ADD CONSTRAINT [UK_Film_Person_Name] UNIQUE NONCLUSTERED
   (
    [Name]
   )
END;
