
	--INSERT data into ProductionHouse table
	INSERT FILM.ProductionHouse (ProductionName, Location) 
	VALUES 
		(N'Focus Features', N'Universal City'),
		(N'Universal Pictures', N'Universal City'),
		(N'Lionsgate',N'Los Angeles'),
		(N'Sony Pictures',N'Culver City'),
		(N'Neon',N'New York'),
		(N'Walt Disney Studios Motion Pictures', N'BurBank'),
		(N'Warner Bros.', N'Hollywood'),
		(N'A24', N'New York'),
		(N'Fox Searchlight Pictures', N'Los Angeles'),
		(N'Paramount Pictures', N'Los Angeles'),
		(N'Twentieth Century Fox', N'Los Angeles')



	--SELECT * FROM FILM.ProductionHouse

	--Insert data into Movies table
	

	 INSERT INTO FILM.Movie  (ProductionId, MovieName, ReleaseDate)
	 VALUES 
	     ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Focus Features'), 'Dark Waters', '2019-11-22'),
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Universal Pictures'), '1917', '2019-12-25'),
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Lionsgate'), 'John Wick:Chapter 3 - Parabellum', '2019-05-15'),
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Sony Pictures'), 'Once Upon a Time...in Hollywood', '2019-07-25'),
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Neon'), 'Parasite', '2019-05-30'),
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Walt Disney Studios Motion Pictures'), 'Aladdin', '2019-05-24'),
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Walt Disney Studios Motion Pictures'), 'Star Wars: Episode IX - The Rise of SkyWalker', '2019-12-18'),
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Sony Pictures'), 'Jumanji:The Next Level', '2019-12-04'), 
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Fox Searchlight Pictures'), 'Jojo Rabbit', '2019-10-18'), 
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Sony Pictures'), 'Little Women', '2019-12-25'), 
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Warner Bros.'), 'Joker', '2019-10-02'), 
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'A24'), 'Midsommar', '2019-07-03'), 
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Walt Disney Studios Motion Pictures'), 'Frozen II', '2019-11-20'), 
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Paramount Pictures'), 'RocketMan', '2019-05-22'), 
		  ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Paramount Pictures'), 'Gemini Man', '2019-10-11'), 
		  ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Warner Bros.'), 'Shazam!', '2019-04-05'), 
		 ( (SELECT ProductionId from Film.ProductionHouse where Film.ProductionHouse.ProductionName = 'Walt Disney Studios Motion Pictures'), 'Avengers:Endgame', '2019-04-24');

  --SELECT * FROM Film.Movie

 --Insert data into Sales table
	 INSERT INTO FILM.Sales  (MovieId, DomesticSales, ForeignSales)
	 VALUES 
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Dark Waters'),11136084,10433989),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = '1917'),159227644,208800000),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'John Wick:Chapter 3 - Parabellum'),171015687,155694040),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Once Upon a Time...in Hollywood'),142502728,231840989),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Parasite'),53369749,200768622),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Star Wars: Episode IX - The Rise of SkyWalker'),515202542,558941706),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Jumanji:The Next Level'),316831246,479744747),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Jojo Rabbit'),33370906,56964119),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Little Women'),108101214,97905289),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Joker'),335451311,738800000),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Midsommar'),27426361,19463936),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Aladdin'),355559216,695134737),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Frozen II'),477373857,97253355),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'RocketMan'),96368160,98811139),
	  	 ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Gemini Man'),48546770,124922746),
	 ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Shazam!'),140371656,225600000),
	  ( ( SELECT MovieId from Film.Movie where Film.Movie.MovieName = 'Avengers:Endgame'),858373000,1939427564);


--SELECT * FROM Film.Sales

--Insert Person  table 

INSERT INTO FILM.Person ([Name], DOB)
 VALUES 
  ('Todd Haynes', '1961-01-02'),
  ('Sam Mendes', '1965-08-01'),
  ('Chad Stahelski','1068-09-20'),
  ('Quentin Tarantino','1963-03-27'),
  ('Bong Joo Ho', '1969-10-14'),
  ('J.J Abrams', '1966-06-27'), 
  ('Jake Kasdan', '1974-10-28'),
  ('Taika Waititi', '1975-08-16'),
  ('Greta Gerwig', '1983-08-04'),
  ('Todd Phillips', '1970-12-20'),
  ('Ari Aster', '1986-07-15'),
  ('Chris Buck','1958-02-25'),
  ('Dexter Fletcher','1966-01-31'),
  ('Joaquin Phoenix','1974-10-28'),
  ('Will Smith','1968-09-25'),
  ('Zachary Levi','1980-09-29'),
  ('Anthony Russo','1970-02-03');


--SELECT * FROM Film.Person
		
INSERT INTO FILM.MoviePerson (PersonID, MovieID,[Role])
VALUES 
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Todd Haynes'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Dark Waters'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Sam Mendes'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='1917'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Chad Stahelski'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='John Wick:Chapter 3 - Parabellum'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Quentin Tarantino'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Once Upon a Time...in Hollywood'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Bong Joo Ho'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Parasite'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='J.J Abrams'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Star Wars: Episode IX - The Rise of SkyWalker'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Jake Kasdan'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Jumanji:The Next Level'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Taika Waititi'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Jojo Rabbit'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Greta Gerwig'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Little Women'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Todd Phillips'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Joker'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Ari Aster'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Midsommar'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Chris Buck'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Frozen II'), 'Director'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Dexter Fletcher'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='RocketMan'), 'Director'),
    ( ( SELECT PersonID from Film.Person where Film.Person.Name='Joaquin Phoenix'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Joker'), 'Lead Actor'),
	 ( ( SELECT PersonID from Film.Person where Film.Person.Name='Will Smith'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Aladdin'), 'Supporting Actor'),
	 	 ( ( SELECT PersonID from Film.Person where Film.Person.Name='Will Smith'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Gemini Man'), 'Lead Actor'),
	 ( ( SELECT PersonID from Film.Person where Film.Person.Name='Zachary Levi'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Shazam!'), 'Lead Actor'),
   ( ( SELECT PersonID from Film.Person where Film.Person.Name='Anthony Russo'), (SELECT MovieID from Film.Movie where Film.Movie.MovieName='Avengers:Endgame'), 'Director');

	--SELECT * FROM FILM.MoviePerson

	
	--Insert data into Film.IndividualAwardsWon
	INSERT INTO Film.IndividualAwardsWon (MoviePersonId) 
	VALUES (
		  ((SELECT MoviePersonId from Film.MoviePerson M INNER JOIN Film.Person P  ON M.PersonId = P.PersonId Where P.Name='Bong Joo Ho'))
		    	 
		);

			INSERT INTO Film.IndividualAwardsWon (MoviePersonId) 
	VALUES (
		  ((SELECT MoviePersonId from Film.MoviePerson M INNER JOIN Film.Person P  ON M.PersonId = P.PersonId Where P.Name='Joaquin Phoenix'))
		    	 
		);
		--Insert data into Film.IndividualAwardsWon
	INSERT INTO Film.IndividualAwardsWon (MoviePersonId) 
	VALUES (
			(SELECT MoviePersonId from Film.MoviePerson M INNER JOIN Film.Person P  ON M.PersonId = P.PersonId Where P.Name='Taika Waititi')
	  	 
		);

	--SELECT * FROM Film.IndividualAwardsWon

	--Insert data into Film.MovieAwardsWon
	
	INSERT INTO FILM.MovieAwardsWon (MovieId,Category) 
	VALUES ( 
	  (SELECT MovieId from Film.Movie Where Film.Movie.MovieName= 'Parasite'), 'Best Picture'),
	  ((SELECT MovieId from Film.Movie Where Film.Movie.MovieName= 'JoJo Rabbit'), 'Adapted Screenplay');

--SELECT * FROM Film.MovieAwardsWon

INSERT INTO Film.Oscars (IndividualAwardsWonId, MovieAwardsWonId, [Year]) 
 VALUES 
	(1,1,('2020')),
	(2,2,('2020'));

		
		
--SELECT * FROM Film.Oscars