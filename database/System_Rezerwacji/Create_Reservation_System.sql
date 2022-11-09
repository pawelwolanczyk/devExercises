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
User_Level INT, --Powi�zany z kolumn� LevelID w Levels, tam wybieram ocje levelu
CONSTRAINT pk_User_UserID PRIMARY KEY (UserID),
CONSTRAINT fk_Users_User_Level FOREIGN KEY (User_Level) REFERENCES Levels(LevelID) 
)


CREATE TABLE Levels(
LevelID INT IDENTITY(1,1) NOT NULL,
Level_Option NVARCHAR(12) NOT NULL, --pocz�tkuj�cy, �redni, �rednio zaawansowany, zaawansowany
Level_Description NVARCHAR(200) NOT NULL, 
CONSTRAINT pk_Levels_LevelID PRIMARY KEY (LevelID),
CONSTRAINT uk_Levels_Level_Option UNIQUE (Level_Option)
)


CREATE TABLE Carnets_Types(
Carnet_TypeID INT IDENTITY(1,1) NOT NULL,
Carnet_Type NVARCHAR(5), --CZYLI MIESI�CZNY, RAZ W TYG; MIESI�CZNY DWA RAZY W TYG ITD.ITP. jednorazowe wej�cie KLUCZ OBCY Z TABEL� Carnet
Carnet_Price FLOAT NOT NULL,
Description_Carnet NVARCHAR(300) NOT NULL, --opisuj� ile trening�w i �e w opcjach karnetu mog� wybra� miejsce gdzie chce chodzi� na trening
Option_Carnet INT NOT NULL, --TU MA MIE� WYPISANY ODNO�NIK DO KA�DEGO DNIA, PONIEWA� W ZALE�NO�CI OD WYBORU KARNETU (JEDEN, DWA, TRZY RAZY W TYGODNIU TO TAKIE MAM OGRANICZENIE WYBORU). I NP. JAK KLIKN� W JEDYNK� TO MAM PONIEDZIA�EK GDZIE MAM WYB�R DO TRENINGU W DW�CH RӯNYCH GODZINACH W DW�CH RӯNYCH LOKALIZACJACH
CONSTRAINT pk_Carnets_Types_Carnet_TypeID PRIMARY KEY (Carnet_TypeID),
CONSTRAINT fk_Carnets_CarnetID FOREIGN KEY (Option_Carnet) REFERENCES Carnets(CarnetID)
)


CREATE TABLE Carnets( --Wybieramy dni tygodnia oraz godziny -> godziny musz� by� powi�zane z tabel� lokalizacji bo godzina treningu jest powi�zana z miejsem treningu 
CarnetID int IDENTITY(1,1) NOT NULL,
Day NVARCHAR(9),-- Podaj� dni tygodnia i te dni tygodnia s� powi�zane z godzin� i lokalizacj� Naje�dzam na dzie� i wy�wietlaj� mi si� lokalizacj� gdzie odbywaj� si� treningi. Klikam w okalizacj� i tam wy�wietlaj� mi si� godziny w jakich odbywaj� si� treningi.
Carnet_Location int NOT NULL, -- Tutaj klucz obcy
CONSTRAINT pk_Carnet_CarnetID PRIMARY KEY (CarnetID),
CONSTRAINT fk_Carnet_Carnet_Location FOREIGN KEY (Carnet_Location) REFERENCES Locations(LocationID)
)


CREATE TABLE Locations(
LocationID int IDENTITY (1,1), 
ShortName NVARCHAR(100), --Podaj� lokalizacje w kolumnie tyle razy ile mamy trning w r�nych godzinach 
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









		