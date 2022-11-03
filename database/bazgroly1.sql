CREATE TABLE Tests(
	TestID int IDENTITY(3,5),-- NOT NULL,
	ColumnText nvarchar(20) NULL,
	ColumnFloat float NOT NULL,
-- CONSTRAINT pk_Balls_BallID PRIMARY KEY (BallID) 
) 

CREATE TABLE Tests2(
	TestID int,-- NOT NULL,
	ColumnText nvarchar(20) NULL,
	ColumnFloat float NOT NULL
CONSTRAINT kluczglowny PRIMARY KEY (TestID) 
) 

CREATE TABLE Tests3(
	ColumnText nvarchar(20),
	ColumnFloat float
CONSTRAINT kluczglowny2 PRIMARY KEY (ColumnText, ColumnFloat) 
) 


DELETE FROM Tests2

DROP Table Tests

SELECT * INTO TestsBackup FROM Tests 

SELECT * FROM Tests3
SELECT * FROM TestsBackup

SELECT * INTO Tests FROM TestsBackup

UPDATE Tests2 SET TestID = 10 WHERE ColumnText = 'Anything2'

CREATE Table TestsBackup AS SELECT * FROM Tests

INSERT INTO Tests2(TestID, ColumnText, ColumnFloat) VALUES (1, 'Anything1', 2.3);
INSERT INTO Tests2(TestID, ColumnText, ColumnFloat) VALUES (2, 'Anything2', 2.3);
INSERT INTO Tests2(TestID, ColumnText, ColumnFloat) VALUES (2, 'Anything2', 2.3);

INSERT INTO Tests2(TestID, ColumnText, ColumnFloat) VALUES (3, 'Anything5', 2.3);

INSERT INTO Tests3(ColumnText, ColumnFloat) VALUES ('Anything1', 2.3);
INSERT INTO Tests3(ColumnText, ColumnFloat) VALUES ('Anything2', 2.3);
INSERT INTO Tests3(ColumnText, ColumnFloat) VALUES ('Anything2', 2.3);
