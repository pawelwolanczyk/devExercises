Potrzebne tabele: 
Wyb�r ilo�ci(opcji trening�w) czyli karnet miesi�czny na raz w tyg, dwa razy w tygodniu, 3 razy w tygodniu, cztery razy w tygodniu, pojedy�cze wej�cie
Miejsca trening�w i godziny (maxymalna ilo�� os�b na treningu)
Zaj�cia (klucz obcy powiazny z lokalizacj�, drugi klucz z Terminami )
Terminy --do przemy�lenia
Kalendarz do rezerwacji 


CREATE TABLE Useres(
UserID int IDENTITY(1,1) NOT NULL,
UserLogin NVARCHAR(50) NOT NULL,
UserHas�o NVARCHAR(25) NOT NULL, --A JAK CHCIA�ABYM OGRANICZY�, �E ILE� NAJMNIEJ ZNAK�W MUSI BY�?
User_Name NVARCHAR(25) NOT NULL,
User_Surname NVARCHAR(30) NOT NULL,
Date_of_Birthday DATE NOT NULL, --rezerwacja tylko dla os�b +18 
Level INT, --Powi�zany z kolumn� LevelID w Levels, tam wybieram ocje levelu/ Je�eli chc� �eby mnie przekierowa�o do tabeli 
--Levels to powinnam ka�dy wiersz tej kolumny wype�ni� s�owem Levels?
CONSTRAINT pk_User_UserID PRIMARY KEY (UserID),
CONSTRAINT fk_Levels_LevekID FOREIGN KEY (Level) REFERENCES Users(LevelID) 
)
Drop table Users


CREATE TABLE Levels(
LevelID INT IDENTITY(1,1) NOT NULL,
Level_Option NVARCHAR(12) NOT NULL, --pocz�tkuj�cy, �redni, �rednio zaawansowany, zaawansowany
Level_Description NVARCHAR(200) NOT NULL, 
CONSTRAINT pk_Levels_LevelID PRIMARY KEY (LevelID),--czy mo�e by� z char po��czony?
)


CREATE TABLE Carnets_Types(
Carnet_TypeID INT IDENTITY(1,1) NOT NULL,
Carnet_Type NVARCHAR(5), --CZYLI MIESI�CZNY, RAZ W TYG; MIESI�CZNY DWA RAZY W TYG ITD.ITP. jednorazowe wej�cie KLUCZ OBCY Z TABEL� Carnet
Carnet_Price FLOAT NOT NULL,
Description NVARCHAR (300),
CONSTRAINT pk_Carnets_Types_Carnet_TypeID PRIMARY KEY (Carnet_TypeID)
)


CREATE TABLE Carnet( --Wybieramy dni tygodnia oraz godziny -> godziny musz� by� powi�zane z tabel� lokalizacji bo godzina treningu jest powi�zana z miejsem treningu 
CarnetID int IDENTITY(1,1) NOT NULL,
Day NVARCHAR(9),-- Podaj� dni tygodnia i te dni tygodnia s� powi�zane z godzin� i lokalizacj� Naje�dzam na dzie� i wy�wietlaj� mi si� lokalizacj� gdzie odbywaj� si� treningi. Klikam w okalizacj� i tam wy�wietlaj� mi si� godziny w jakich odbywaj� si� treningi.
Carnet_Location int NOT NULL, -- Tutaj klucz obcy
CONSTRAINT pk_Carnet_CarnetID PRIMARY KEY (CarnetID),
CONSTRAINT fk_Carnet_Types_Carnet_TypeID FOREIGN KEY (CarnetID) REFERENCES Carnets_Types(Carnet_TypeID), --Czy klucz obcy mo�e by� charem??? nie musi by� int?
CONSTRAINT fk_Carnet_Carnet_Location FOREIGN KEY (Carnet_Location) REFERENCES Locations(LocationID)
)


CREATE TABLE Locations(
LocationID int IDENTITY (1,1), 
ShortName NVARCHAR(100), --Podaj� lokalizacje w kolumnie 
Location_Time int, --Tu klucz obcy do tabeli time 
CONSTRAINT pk_Locations_LocationID PRIMARY KEY (LocationID),
CONSTRAINT fk_Locations_Location_Time FOREIGN KEY (Location_Time) REFERENCES Times(TimeId)
)


CREATE TABLE Times(
TimeId int IDENTITY(1,1) NOT NULL,
Day_Time Time NOT NULL,
CONSTRAINT pk_Times_TimeID PRIMARY KEY (TimeID),
CONSTRAINT uk_Times_Day_Time UNIQUE (Day_Time),
)

Normalizacja bazy danych
Aliansy
TRIGGER (WYZWALACZ)
CONSTREINTS: 
default
not null
primary key
unique - unikatowo�� (mo�emy doda� dwie kolumny, oczywi�cie najlepiej doda� sobie CONSTRAINT I NAZW�)Czyli np mamy tv i tam jest UNIQUE to on nam nie pozwoli doda�
jeszcze raz tego samego produkty o tym samym kodzie, tylko zrobimy UPDATE (czyli zaaktualizuje sobi� ju� istniej�cy wiersz) 
foreign key
check-- ALTER TABLE ........... ADDD CONSTRAINT CK_... CHECK( nazwa kolumny > od czego AND nawaz kolumny = czemu� )


SELECT * FROM Bats, Rubbers 
WHERE (Bats.Rubber1ID = Rubbers.RubberID OR Bats.Rubber2ID = Rubbers.RubberID) 
AND Bats.BatID = 5

SELECT Bats.Name, Bats.Description, Rubbers.Manufacturer, Rubbers.Name, Rubbers.Thickness, Rubbers....... 

INNER JOIN Rubbers ON Bats.Rubber1ID = Rubbers.RubberID AND Bats.Rubber2ID = Rubbers.RubberID
WHERE Bats.BatID = 5


Za pomoc� where i INNER JOIN wyci�gni�cie informacji o desce kt�ra jest u�ywana w danym zestawie


SELECT * FROM Blades
INNER JOIN Bats ON Blades.BladeID = Bats.BladeID

SELECT * FROM Blades
 LEFT INNER JOIN Bats ON Blades.BladeID = Bats.BladeID
WHERE Bats.BatID IS NULL


SELECT Bats.* FROM Bats --. SPRAWIA, �E WY�WIETLAJ� nAM SI� TYLKO TE KOLUMNY KT�RE POCHODZ� Z BATS, ALE WYKONUJE NAM CA�Y PRCES TYLKO NIE 
--WIDZIMY PRAWEJ STRONY Blades.BladeID = Bats.BladeID, Dlatego mog� nam si� te� pojawia� duplikaty 
INNER JOIN Bats ON Blades.BladeID = Bats.BladeID

SELECT * FROM Blades WHERE BladeID IN (SELECT BladeID FROM Bats) --To co znajduje si� w nawiasie wykinuje si� pierwsze
SELECT * FROM Blades WHERE BladeID NOT IN (SELECT BladeID FROM Bats)

Zr�bmy selecta kt�ry w�wietli wszystkie ok�adziny, kt�re nie by�y u�yte w zestawach --PRACA DOMOWA 

SELECT * FROM Rubbers WHERE RubberID BEETWEN 1 AND 10
SELECT * FROM Rubbers WHERE RubberID BEETWEN 20 AND 30

SELECT * FROM Rubbers WHERE RubberID BEETWEN 1 AND 10 OR RubberID BEETWEN 20 AND 30

SELECT * FROM Rubbers WHERE RubberID BEETWEN 1 AND 10
UNION--pRZY U�YWANIU UNION musz� by� te same kolumny
SELECT * FROM Rubbers WHERE RubberID BEETWEN 20 AND 30

UNION ALL-- SPRAWDZI� DOK�ADNIE

SELECT SUM(Price) FROM Rubbers

SELECT SUM(Price) AS  Sum FROM Rubbers

SELECT MAX(Price) AS  Max FROM Rubbers


DISTINCT -- ODFILTROWUJE CZYLI USU� DUPLIKATY -> USUWA Z WYNIKU, ALE NIE Z PROCESOWANIA 







		