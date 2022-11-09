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
User_Level INT, --Powi¹zany z kolumn¹ LevelID w Levels, tam wybieram ocje levelu
CONSTRAINT pk_User_UserID PRIMARY KEY (UserID),
CONSTRAINT fk_Users_User_Level FOREIGN KEY (User_Level) REFERENCES Levels(LevelID) 
)


CREATE TABLE Levels(
LevelID INT IDENTITY(1,1) NOT NULL,
Level_Option NVARCHAR(12) NOT NULL, --pocz¹tkuj¹cy, œredni, œrednio zaawansowany, zaawansowany
Level_Description NVARCHAR(200) NOT NULL, 
CONSTRAINT pk_Levels_LevelID PRIMARY KEY (LevelID),
CONSTRAINT uk_Levels_Level_Option UNIQUE (Level_Option)
)


CREATE TABLE Carnets_Types(
Carnet_TypeID INT IDENTITY(1,1) NOT NULL,
Carnet_Type NVARCHAR(5), --CZYLI MIESIÊCZNY, RAZ W TYG; MIESIÊCZNY DWA RAZY W TYG ITD.ITP. jednorazowe wejœcie KLUCZ OBCY Z TABEL¥ Carnet
Carnet_Price FLOAT NOT NULL,
Description_Carnet NVARCHAR(300) NOT NULL, --opisujê ile treningów i ¿e w opcjach karnetu mogê wybraæ miejsce gdzie chce chodziæ na trening
Option_Carnet INT NOT NULL, --TU MA MIEÆ WYPISANY ODNOŒNIK DO KA¯DEGO DNIA, PONIEWA¯ W ZALE¯NOŒCI OD WYBORU KARNETU (JEDEN, DWA, TRZY RAZY W TYGODNIU TO TAKIE MAM OGRANICZENIE WYBORU). I NP. JAK KLIKNÊ W JEDYNKÊ TO MAM PONIEDZIA£EK GDZIE MAM WYBÓR DO TRENINGU W DWÓCH RÓ¯NYCH GODZINACH W DWÓCH RÓ¯NYCH LOKALIZACJACH
CONSTRAINT pk_Carnets_Types_Carnet_TypeID PRIMARY KEY (Carnet_TypeID),
CONSTRAINT fk_Carnets_CarnetID FOREIGN KEY (Option_Carnet) REFERENCES Carnets(CarnetID)
)


CREATE TABLE Carnets( --Wybieramy dni tygodnia oraz godziny -> godziny musz¹ byæ powi¹zane z tabel¹ lokalizacji bo godzina treningu jest powi¹zana z miejsem treningu 
CarnetID int IDENTITY(1,1) NOT NULL,
Day NVARCHAR(9),-- Podajê dni tygodnia i te dni tygodnia s¹ powi¹zane z godzin¹ i lokalizacj¹ Naje¿dzam na dzieñ i wyœwietlaj¹ mi siê lokalizacjê gdzie odbywaj¹ siê treningi. Klikam w okalizacjê i tam wyœwietlaj¹ mi siê godziny w jakich odbywaj¹ siê treningi.
Carnet_Location int NOT NULL, -- Tutaj klucz obcy
CONSTRAINT pk_Carnet_CarnetID PRIMARY KEY (CarnetID),
CONSTRAINT fk_Carnet_Carnet_Location FOREIGN KEY (Carnet_Location) REFERENCES Locations(LocationID)
)


CREATE TABLE Locations(
LocationID int IDENTITY (1,1), 
ShortName NVARCHAR(100), --Podajê lokalizacje w kolumnie tyle razy ile mamy trning w ró¿nych godzinach 
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









		