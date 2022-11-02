INSERT INTO Participants VALUES ('Monika', 'Kozidrak', 12.12, 'Warszawa')
INSERT INTO Participants VALUES ('Stanis�awa', 'Wo�osz', 24.02, 'D�browa G�rnicza')
INSERT INTO Participants VALUES ('Janusz', 'Woskowski', 19.04, 'Lublin')
INSERT INTO Participants (Name, Surname, Date_of_Birthday, City) VALUES ('Marcin', 'W�odzis�aw', 1.09, 'Krak�w')
INSERT INTO Participants VALUES ('Piotrek', 'Kucharczyk', 3.11, 'Katowice')

INSERT INTO Racket (Participants_Name, Racket_Name, Rubbers1_Name, Rubbers2_Name) 
SELECT (SELECT ParticipantsID FROM Participants WHERE ParticipantsID = 1), 
'Butterfly', 'Tenergy05', 'Tenergy19'

INSERT INTO Racket (Participants_Name, Racket_Name, Rubbers1_Name, Rubbers2_Name)
SELECT (SELECT ParticipantsID FROM Participants WHERE ParticipantsID = 2),
'Tibhar', 'MX-P', 'Rakza9'

