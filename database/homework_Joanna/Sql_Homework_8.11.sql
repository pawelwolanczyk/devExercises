--(Z Bats) Za pomoc� where i INNER JOIN wyci�gnijcie informacje o desce kt�ra jest u�ywana w danym zestawie
SELECT * FROM Bats, Blades
WHERE (Bats.BladeID = Blades.BladeID)

SELECT * FROM Bats, Blades
INNER JOIN Bats ON Bats.BladeID = Blades.BladeID

INNER JOIN Rubbers ON Bats.Rubber1ID = Rubbers.RubberID AND Bats.Rubber2ID = Rubbers.RubberID
WHERE Bats.BatID = 5

SELECT * FROM Blades
INNER JOIN Bats ON Blades.BladeID = Bats.BladeID

SELECT * FROM Bats, Blades
WHERE (Bats.BladeID = Blades.BladeID)

SELECT * FROM Bats, Rubbers 
WHERE (Bats.Rubber1ID = Rubbers.RubberID OR Bats.Rubber2ID = Rubbers.RubberID) 
AND Bats.BatID = 5



