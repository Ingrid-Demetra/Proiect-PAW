INSERT INTO Profesori (Nume, Prenume, Catedra) VALUES ('Popescu', 'Ion', 'Informatica')
INSERT INTO Profesori (Nume, Prenume, Catedra) VALUES ('Ionescu', 'Maria', 'Matematica')
INSERT INTO Profesori (Nume, Prenume, Catedra) VALUES ('Dumitrescu', 'Andrei', 'Fizica')

INSERT INTO Materii (Denumire, AnStudiu) VALUES ('Baze de Date', 2)
INSERT INTO Materii (Denumire, AnStudiu) VALUES ('Algoritmi', 1)
INSERT INTO Materii (Denumire, AnStudiu) VALUES ('Programare Web', 3)

INSERT INTO Sali (NumarSala, Capacitate) VALUES (101, 30)
INSERT INTO Sali (NumarSala, Capacitate) VALUES (202, 50)
INSERT INTO Sali (NumarSala, Capacitate) VALUES (301, 25)

INSERT INTO OreProgramate (ProfesorID, MaterieID, SalaID, Zi, OraInceput, OraSfarsit) 
VALUES (1, 1, 1, 'Luni', '08:00', '10:00')
INSERT INTO OreProgramate (ProfesorID, MaterieID, SalaID, Zi, OraInceput, OraSfarsit) 
VALUES (2, 2, 2, 'Marti', '10:00', '12:00')
INSERT INTO OreProgramate (ProfesorID, MaterieID, SalaID, Zi, OraInceput, OraSfarsit) 
VALUES (3, 3, 3, 'Miercuri', '12:00', '14:00')