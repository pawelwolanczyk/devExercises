-- zadanie start Rubbers
INSERT INTO Rubbers VALUES ('Yasaka', 'Rakza 7', 2.0, 90, 160, 'Red')
INSERT INTO Rubbers VALUES ('Yasaka', 'Rakza X', 1.8, 89, 180, 'Black')
INSERT INTO Rubbers VALUES ('Yasaka', 'Rakza 9', 2.0, 90, 180, 'Black')
INSERT INTO Rubbers VALUES ('Yasaka', 'Rigan', 1.8, 90, 130, 'Black')
INSERT INTO Rubbers VALUES ('Yasaka', 'Mark V', 2.0, 89, 130, 'Red')
INSERT INTO Rubbers (Manufacturer, Name, Thickness, Weight, Price, Color) VALUES ('Yasaka', 'Shining Dragon', 2.0, 87, 170, 'Red')
Insert Into Rubbers (Manufacturer, Name, Thickness, Weight, Price, Color) Values ('Yasaka', 'Anti Power', 2.0, 89, 130, 'Black')
Insert Into Rubbers (Manufacturer, Name, Thickness, Weight, Price, Color) Values ('Yasaka', 'Crastar', 1.5, 89, 95, 'Black')
Insert Into Rubbers (Manufacturer, Name, Thickness, Weight, Price, Color) Values ('Yasaka', 'Trick Anti', 1.5, 89, 130, 'Red')
Insert Into Rubbers (Manufacturer, Name, Thickness, Weight, Price, Color) Values ('Yasaka', 'Rising Dragon', 2.0, 90, 170, 'Black')

-- zadanie start Balls
INSERT INTO Balls (Type, Manufacturer, Name, Price) VALUES ('Plastic', 'Yasaka', 'Pileczki turniejowe', 15)
INSERT INTO Balls VALUES ('Plastik','Tibhar', 'Ekstra', 79)
INSERT INTO Balls (Type, Manufacturer, Name, Price) VALUES ('Metal', 'Yasaka', 'Pileczki kosmiczne', 27)

-- zadanie start Blades
INSERT INTO Blades (Manufacturer, Name, Weight, Price) VALUES ('Yasaki', 'Advance 3D', 70, 140)
INSERT INTO Blades (Manufacturer, Name, Weight, Price) VALUES ('Yasaki', 'Alnade', 65, 160)
INSERT INTO Blades (Manufacturer, Name, Weight, Price) Values ('Yasaki', 'Balsa', 65, 160)
Insert Into Blades (Manufacturer, Name, Weight, Price) Values ('Yasaki', 'Flack W7', 65, 215)
Insert Into Blades (Manufacturer, Name, Weight, Price) Values ('Yasaki', 'Galaxia', 65, 180)

--zadanie start Bats
INSERT INTO Bats (Name, Description, Rubber1ID, Rubber2ID, BladeID)
SELECT 'Zestaw pierwszy', 'super', 
(SELECT RubberID FROM Rubbers WHERE Name = 'Evolution EL-D' AND Thickness = 2 AND Color = 'Black'), 
(SELECT RubberID FROM Rubbers WHERE Name = 'Rhyzen Fire Blue' AND Thickness = 2.1), 
(SELECT BladeID FROM Blades WHERE Name = 'Extension OC' and Price = 398)

INSERT INTO Bats (Name, Description, Rubber1ID, Rubber2ID, BladeID)
SELECT 'Cos + cos ekstra', 'Jeszce szybszy zestaw', 
(Select RubberID FROM Rubbers WHERE Name = 'Tenergy 19' and Thickness = 2.1),
(Select RubberID From Rubbers Where Manufacturer = 'Mizuno' and Thickness = 1.9 and Weight = 84),
(Select BladeID FROM Blades Where Name = 'Gauzy BL7 OFF' and Price = 158)