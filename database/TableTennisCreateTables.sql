CREATE TABLE Blades(
	BladeID int IDENTITY(1,1) NOT NULL,
	Manufacturer nvarchar(50) NULL,
	Name nvarchar(100) NULL,
	Weight tinyint NULL,
	Price float NULL,
	Reviews varchar(max) NULL,
 CONSTRAINT pk_Blades_BladeID PRIMARY KEY (BladeID)
)

CREATE TABLE Rubbers(
	RubberID int IDENTITY(1,1) NOT NULL,
	Manufacturer nvarchar(50) NULL,
	Name nvarchar(100) NULL,
	Thickness float NULL,
	Weight tinyint NULL,
	Price float NULL,
	Color nvarchar(20) NULL,
 CONSTRAINT pk_Rubbers_RubberID PRIMARY KEY (RubberID) 
)

CREATE TABLE Balls(
	BallID int IDENTITY(1,1) NOT NULL,
	Type varchar(20) NULL,
	Manufacturer varchar(50) NULL,
	Name nvarchar(100) NULL,
	Price float NULL,
 CONSTRAINT pk_Balls_BallID PRIMARY KEY (BallID) 
) 

CREATE TABLE Bats(
	BatID [int] IDENTITY(1,1) NOT NULL,
	Name nvarchar(50) NULL,
	Description nvarchar(300) NULL,
	Rubber1ID int NOT NULL,
	Rubber2ID int NOT NULL,
	BladeID int NOT NULL,
 CONSTRAINT pk_Bats_BatID PRIMARY KEY (BatID),
 CONSTRAINT fk_Rubbers_Rubber1ID FOREIGN KEY (Rubber1ID) REFERENCES Rubbers(RubberID),
 CONSTRAINT fk_Rubbers_Rubber2ID FOREIGN KEY (Rubber2ID) REFERENCES Rubbers(RubberID),
 CONSTRAINT fk_Blades_BladeID FOREIGN KEY (BladeID) REFERENCES Blades(BladeID)
)