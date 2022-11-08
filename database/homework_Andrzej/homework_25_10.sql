SELECT * FROM rubbers WHERE Price >200 AND Price <300
SELECT * FROM rubbers WHERE Color='Black' AND Thickness >=2
SELECT COUNT (*) FROM rubbers
SELECT * FROM rubbers WHERE Color='Black' AND Thickness=2.1 ORDER BY price ASC
SELECT * FROM rubbers WHERE Manufacturer='Butterfly' AND Name LIKE 'Tenergy%'
UPDATE rubbers SET Price=385 WHERE manufacturer='butterfly' AND name LIKE 'dignics%'
