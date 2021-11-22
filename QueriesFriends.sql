-- Link w3schools SQL  - https://www.w3schools.com/sql/default.asp

--CREATE TABLE [dbo].[Friends] (
--    [FriendID]  INT           NOT NULL IDENTITY,
--    [FirstName] VARCHAR (255) NULL,
--    [LastName]  VARCHAR (255) NULL,
--    [Email]     VARCHAR (255) NULL,
--    [City]      VARCHAR (255) NULL,
--    [BirthDate] DATE          NULL, 
--    CONSTRAINT [PK_Friends] PRIMARY KEY ([FriendID])
--);

--INSERT INTO Friends ( FirstName, LastName, Email, City, BirthDate)
--VALUES ('Leonardo', 'Silva', 'email@email.com', 'Rio', '2021-11-10')

--INSERT INTO Friends ( FirstName, LastName, Email, City, BirthDate)
--VALUES ('Henrique', 'Silva', 'email@email.com', 'Rio', '2021-11-09')

--INSERT INTO Friends ( FirstName, LastName, Email, City, BirthDate)
--VALUES ('Larissa', 'Silva', 'email@email.com', 'Caxias', '2021-11-08')

--INSERT INTO Friends ( FirstName, LastName, Email, City, BirthDate)
--VALUES ('Emanoele', 'Silva', 'email@email.com', 'Niteroi', '2021-11-07')

-- SELECT * FROM Friends ORDER BY BirthDate ASC; 

-- SELECT * FROM Friends WHERE BirthDate BETWEEN '2021-11-07' AND '2021-11-09';

-- SELECT * FROM Friends WHERE FirstName LIKE 'l%'; 

-- SELECT * FROM Friends WHERE City='Rio' AND BirthDate='2021-11-09';

-- UPDATE Friends SET LastName = 'Schmidt', City= 'Frankfurt' WHERE FirstName = 'Larissa' AND LastName='Silva';

-- DELETE FROM Friends WHERE FirstName='Leonardo' AND City='Rio';

