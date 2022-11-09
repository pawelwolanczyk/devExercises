Potrzebne tabele: 
Wybór iloœci(opcji treningów) czyli karnet miesiêczny na raz w tyg, dwa razy w tygodniu, 3 razy w tygodniu, cztery razy w tygodniu, pojedyñcze wejœcie
Miejsca treningów i godziny (maxymalna iloœæ osób na treningu)
Zajêcia (klucz obcy powiazny z lokalizacj¹, drugi klucz z Terminami )
Terminy --do przemyœlenia
Kalendarz do rezerwacji 


CREATE TABLE Useres(
UserID int IDENTITY(1,1) NOT NULL,
UserLogin NVARCHAR(50) NOT NULL,
UserHas³o NVARCHAR(25) NOT NULL, --A JAK CHCIA£ABYM OGRANICZYÆ, ¯E ILEŒ NAJMNIEJ ZNAKÓW MUSI BYÆ?
User_Name NVARCHAR(25) NOT NULL,
User_Surname NVARCHAR(30) NOT NULL,
Date_of_Birthday DATE NOT NULL, --rezerwacja tylko dla osób +18 
Level INT, --Powi¹zany z kolumn¹ LevelID w Levels, tam wybieram ocje levelu/ Je¿eli chcê ¿eby mnie przekierowa³o do tabeli 
--Levels to powinnam ka¿dy wiersz tej kolumny wype³niæ s³owem Levels?
CONSTRAINT pk_User_UserID PRIMARY KEY (UserID),
CONSTRAINT fk_Levels_LevekID FOREIGN KEY (Level) REFERENCES Users(LevelID) 
)
Drop table Users


CREATE TABLE Levels(
LevelID INT IDENTITY(1,1) NOT NULL,
Level_Option NVARCHAR(12) NOT NULL, --pocz¹tkuj¹cy, œredni, œrednio zaawansowany, zaawansowany
Level_Description NVARCHAR(200) NOT NULL, 
CONSTRAINT pk_Levels_LevelID PRIMARY KEY (LevelID),--czy mo¿e byæ z char po³¹czony?
)


CREATE TABLE Carnets_Types(
Carnet_TypeID INT IDENTITY(1,1) NOT NULL,
Carnet_Type NVARCHAR(5), --CZYLI MIESIÊCZNY, RAZ W TYG; MIESIÊCZNY DWA RAZY W TYG ITD.ITP. jednorazowe wejœcie KLUCZ OBCY Z TABEL¥ Carnet
Carnet_Price FLOAT NOT NULL,
Description NVARCHAR (300),
CONSTRAINT pk_Carnets_Types_Carnet_TypeID PRIMARY KEY (Carnet_TypeID)
)


CREATE TABLE Carnet( --Wybieramy dni tygodnia oraz godziny -> godziny musz¹ byæ powi¹zane z tabel¹ lokalizacji bo godzina treningu jest powi¹zana z miejsem treningu 
CarnetID int IDENTITY(1,1) NOT NULL,
Day NVARCHAR(9),-- Podajê dni tygodnia i te dni tygodnia s¹ powi¹zane z godzin¹ i lokalizacj¹ Naje¿dzam na dzieñ i wyœwietlaj¹ mi siê lokalizacjê gdzie odbywaj¹ siê treningi. Klikam w okalizacjê i tam wyœwietlaj¹ mi siê godziny w jakich odbywaj¹ siê treningi.
Carnet_Location int NOT NULL, -- Tutaj klucz obcy
CONSTRAINT pk_Carnet_CarnetID PRIMARY KEY (CarnetID),
CONSTRAINT fk_Carnet_Types_Carnet_TypeID FOREIGN KEY (CarnetID) REFERENCES Carnets_Types(Carnet_TypeID), --Czy klucz obcy mo¿e byæ charem??? nie musi byæ int?
CONSTRAINT fk_Carnet_Carnet_Location FOREIGN KEY (Carnet_Location) REFERENCES Locations(LocationID)
)


CREATE TABLE Locations(
LocationID int IDENTITY (1,1), 
ShortName NVARCHAR(100), --Podajê lokalizacje w kolumnie 
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
unique - unikatowoœæ (mo¿emy dodaæ dwie kolumny, oczywiœcie najlepiej dodaæ sobie CONSTRAINT I NAZWÊ)Czyli np mamy tv i tam jest UNIQUE to on nam nie pozwoli dodaæ
jeszcze raz tego samego produkty o tym samym kodzie, tylko zrobimy UPDATE (czyli zaaktualizuje sobiê ju¿ istniej¹cy wiersz) 
foreign key
check-- ALTER TABLE ........... ADDD CONSTRAINT CK_... CHECK( nazwa kolumny > od czego AND nawaz kolumny = czemuœ )


SELECT * FROM Bats, Rubbers 
WHERE (Bats.Rubber1ID = Rubbers.RubberID OR Bats.Rubber2ID = Rubbers.RubberID) 
AND Bats.BatID = 5

SELECT Bats.Name, Bats.Description, Rubbers.Manufacturer, Rubbers.Name, Rubbers.Thickness, Rubbers....... 

INNER JOIN Rubbers ON Bats.Rubber1ID = Rubbers.RubberID AND Bats.Rubber2ID = Rubbers.RubberID
WHERE Bats.BatID = 5


Za pomoc¹ where i INNER JOIN wyci¹gniêcie informacji o desce która jest u¿ywana w danym zestawie


SELECT * FROM Blades
INNER JOIN Bats ON Blades.BladeID = Bats.BladeID

SELECT * FROM Blades
 LEFT INNER JOIN Bats ON Blades.BladeID = Bats.BladeID
WHERE Bats.BatID IS NULL


SELECT Bats.* FROM Bats --. SPRAWIA, ¯E WYŒWIETLAJ¥ nAM SIÊ TYLKO TE KOLUMNY KTÓRE POCHODZ¥ Z BATS, ALE WYKONUJE NAM CA£Y PRCES TYLKO NIE 
--WIDZIMY PRAWEJ STRONY Blades.BladeID = Bats.BladeID, Dlatego mog¹ nam siê te¿ pojawiaæ duplikaty 
INNER JOIN Bats ON Blades.BladeID = Bats.BladeID

SELECT * FROM Blades WHERE BladeID IN (SELECT BladeID FROM Bats) --To co znajduje siê w nawiasie wykinuje siê pierwsze
SELECT * FROM Blades WHERE BladeID NOT IN (SELECT BladeID FROM Bats)

Zróbmy selecta który wœwietli wszystkie ok³adziny, które nie by³y u¿yte w zestawach --PRACA DOMOWA 

SELECT * FROM Rubbers WHERE RubberID BEETWEN 1 AND 10
SELECT * FROM Rubbers WHERE RubberID BEETWEN 20 AND 30

SELECT * FROM Rubbers WHERE RubberID BEETWEN 1 AND 10 OR RubberID BEETWEN 20 AND 30

SELECT * FROM Rubbers WHERE RubberID BEETWEN 1 AND 10
UNION--pRZY U¯YWANIU UNION musz¹ byæ te same kolumny
SELECT * FROM Rubbers WHERE RubberID BEETWEN 20 AND 30

UNION ALL-- SPRAWDZIÆ DOK£ADNIE

SELECT SUM(Price) FROM Rubbers

SELECT SUM(Price) AS  Sum FROM Rubbers

SELECT MAX(Price) AS  Max FROM Rubbers


DISTINCT -- ODFILTROWUJE CZYLI USUÑ DUPLIKATY -> USUWA Z WYNIKU, ALE NIE Z PROCESOWANIA 







		