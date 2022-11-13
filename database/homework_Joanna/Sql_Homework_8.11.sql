--(Z Bats) Za pomoc¹ where i INNER JOIN wyci¹gnijcie informacje o desce która jest u¿ywana w danym zestawie
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



