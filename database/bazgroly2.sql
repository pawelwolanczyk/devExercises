CREATE TABLE Tests4(
	Id int IDENTITY(1,1) PRIMARY KEY,
	ColumnText nvarchar(20),
	ColumnFloat float
) 

SELECT * FROM sys.all_objects

--contraints:
--DEFAULT
--NOT NULL
--PRIMARY KEY
--FOREIGN KEY
--UNIQUE
--CHECK

CREATE TABLE Persons (
    ID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int,
	CONSTRAINT uk_LastName UNIQUE(LastName)
);

INSERT INTO Persons VALUES(1, 'Nowak', 'James', 60)
INSERT INTO Persons VALUES(1, 'Nowak', 'Bruce', 60)

SELECT * FROM Persons

INSERT INTO Persons VALUES(1, 'Wayne', 'John', 30)

ALTER TABLE  Persons DROP CONSTRAINT uk_LastName

ALTER TABLE  Persons ADD CONSTRAINT uk_LastName UNIQUE(LastName)

DELETE FROM Persons WHERE LastName = 'Wayne' and FirstName = 'John'

ALTER TABLE  Persons ADD CONSTRAINT ck_Age CHECK(Age > 18)

ALTER TABLE  Persons ADD UNIQUE(Age, LastName)

INSERT INTO Persons VALUES(1, 'Kent', 'Clark', 5)

INSERT INTO Persons VALUES(1, 'Kent', 'Clark', 19)

SELECT * FROM Bats

SELECT * FROM Rubbers WHERE RubberId IN (38, 32)

INSERT INTO Bats(Name, Description, Rubber1ID, Rubber2ID, BladeID) VALUES('', '', 58, 59, 9)

DELETE FROM Rubbers WHERE RubberID = 27

SELECT Bats.Name AS 'Nazwa_rakietki', Bats.Description, Rubbers.Manufacturer, Rubbers.Name AS 'Nazwa_okladziny', Rubbers.Thickness, Rubbers.Weight, Rubbers.Color
FROM Bats, Rubbers 
WHERE (Bats.Rubber1ID = Rubbers.RubberID OR Bats.Rubber2ID = Rubbers.RubberID)
	AND Bats.BatID = 5


SELECT Bats.Name AS 'Nazwa_rakietki', Bats.Description, Rubbers.Manufacturer, Rubbers.Name AS 'Nazwa_okladziny', Rubbers.Thickness, Rubbers.Weight, Rubbers.Color
FROM Bats
INNER JOIN Rubbers ON Bats.Rubber1ID = Rubbers.RubberID OR Bats.Rubber2ID = Rubbers.RubberID
WHERE Bats.BatID = 5

SELECT * FROM Blades

SELECT * FROM Blades
LEFT JOIN Bats ON Blades.BladeID = Bats.BladeID
WHERE Bats.BatID IS NULL

SELECT DISTINCT Bats.* FROM Bats
RIGHT JOIN Blades ON Blades.BladeID = Bats.BladeID

SELECT * FROM Bats

SELECT * FROM Blades
INNER JOIN Bats ON Blades.BladeID = Bats.BladeID
WHERE Bats.BatID IS NOT NULL

SELECT DISTINCT Manufacturer, Name FROM Rubbers ORDER BY Name

SELECT * FROM Rubbers WHERE RubberID BETWEEN 1 AND 10
SELECT * FROM Rubbers WHERE RubberID BETWEEN 20 AND 30

SELECT * FROM Rubbers WHERE RubberID BETWEEN 1 AND 10 OR RubberID BETWEEN 20 AND 30

SELECT Manufacturer FROM Rubbers WHERE RubberID BETWEEN 1 AND 10
UNION ALL
SELECT Name FROM Rubbers WHERE RubberID BETWEEN 20 AND 30


SELECT * FROM Blades WHERE BladeID NOT IN (SELECT BladeID FROM Bats)

SELECT * FROM Rubbers

SELECT Max(Price) AS Max FROM Rubbers


