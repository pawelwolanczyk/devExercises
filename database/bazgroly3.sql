SELECT Manufacturer, AVG(Price) AS AveragePrice, Max(Price) AS MaxPrice, Min(Price) AS MinPrice FROM Rubbers
GROUP BY Manufacturer
HAVING AVG(Price) > 200

SELECT Manufacturer, Name, AVG(Price) FROM Rubbers
GROUP BY Manufacturer, Name

SELECT DISTINCT Manufacturer from Rubbers

SELECT TOP 5 RubberID, Manufacturer, Name, Price FROM Rubbers ORDER BY Price DESC

SELECT Bats.Name AS 'Nazwa_rakietki', Bats.Description, Rubbers.Manufacturer, Rubbers.Name AS 'Nazwa_okladziny', Rubbers.Thickness, Rubbers.Weight, Rubbers.Color
FROM Bats
INNER JOIN Rubbers ON Bats.Rubber1ID = Rubbers.RubberID OR Bats.Rubber2ID = Rubbers.RubberID

CREATE VIEW BatsWithDetails
AS
SELECT dbo.Bats.Name AS 'Nazwa_rakietki', dbo.Bats.Description, dbo.Rubbers.Manufacturer, dbo.Rubbers.Name AS 'Nazwa_okladziny', dbo.Rubbers.Thickness, dbo.Rubbers.Weight, dbo.Rubbers.Color
FROM     dbo.Bats INNER JOIN
                  dbo.Rubbers ON dbo.Bats.Rubber1ID = dbo.Rubbers.RubberID OR dbo.Bats.Rubber2ID = dbo.Rubbers.RubberID

SELECT * FROM BatsWithDetails

CREATE TRIGGER reminder2  
ON Balls
AFTER INSERT, UPDATE
AS RAISERROR ('Notify Customer Relations', 16, 10);  

INSERT INTO Balls (Type, Manufacturer, Name, Price) VALUES ('Plastik', 'Tibhar', '** 40+ Cell-Free', 46)

SELECT * FROM Balls

CREATE TRIGGER uppercase_tri ON Balls FOR INSERT, UPDATE AS
IF UPDATE(Manufacturer)
BEGIN
UPDATE Balls
SET Manufacturer = upper(j.Manufacturer)
FROM Balls t
JOIN inserted j ON t.BallID = j.BallID
END

SELECT * FROM Balls

SELECT b.Name AS 'Nazwa_rakietki', b.Description, r.Manufacturer, r.Name AS 'Nazwa_okladziny', r.Thickness, r.Weight, r.Color
FROM Bats b, Rubbers r
WHERE (b.Rubber1ID = r.RubberID OR b.Rubber2ID = r.RubberID)
	AND b.BatID = 5

SELECT b.*, r.*
FROM Bats b
INNER JOIN Rubbers r ON b.Rubber1ID = r.RubberID OR b.Rubber2ID = r.RubberID
WHERE b.BatID = 5

INSERT INTO Balls (Type, Manufacturer, Name, Price) VALUES ('Plastik', 'Tibhar', '** 40+ Cell-Free', 46)

SELECT @@IDENTITY

INSERT INTO Blades (Manufacturer, Name, Weight, Price) VALUES ('Dr. Neubauer', 'Kung Fu', 70, 250)

INSERT INTO Rubbers VALUES ('Butterfly', 'Rozena', 2.1, 90, 450, 'Black')

