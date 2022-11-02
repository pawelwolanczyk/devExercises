CREATE TABLE Participants(
ParticipantsID int IDENTITY(1,1) NOT NULL,
Name NVARCHAR(50) NULL,
Surname NVARCHAR(50) NULL,
Date_of_Birthday float NULL,
City NVARCHAR(100) NULL,
CONSTRAINT pk_Participants_ParticipantsID PRIMARY KEY (ParticipantsID)
)
CREATE TABLE Racket (
RacketID [int] IDENTITY(1,1) NOT NULL,
Participants_Name INT NOT NULL,
Racket_Name NVARCHAR(50) NULL,
Rubbers1_Name NVARCHAR(50) NULL,
Rubbers2_Name NVARCHAR(50) NULL,
CONSTRAINT pk_Racket_RacketID PRIMARY KEY (RacketID),
FOREIGN KEY (Participants_Name) REFERENCES Participants(ParticipantsID)
)