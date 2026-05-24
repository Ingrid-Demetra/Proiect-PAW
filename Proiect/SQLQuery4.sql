INSERT INTO Profesori (Nume, Prenume, Catedra) VALUES ('Stanescu', 'Elena', 'Chimie')
INSERT INTO Profesori (Nume, Prenume, Catedra) VALUES ('Marinescu', 'Mihai', 'Fizica')

INSERT INTO Materii (Denumire, AnStudiu) VALUES ('Retele de Calculatoare', 2)
INSERT INTO Materii (Denumire, AnStudiu) VALUES ('Sisteme de Operare', 1)
INSERT INTO Materii (Denumire, AnStudiu) VALUES ('Inteligenta Artificiala', 3)

INSERT INTO Sali (NumarSala, Capacitate) VALUES (2023, 40)
INSERT INTO Sali (NumarSala, Capacitate) VALUES (2024, 35)
INSERT INTO Sali (NumarSala, Capacitate) VALUES (105, 20)

INSERT INTO OreProgramate (ProfesorID, MaterieID, SalaID, Zi, OraInceput, OraSfarsit)
VALUES (1, 4, 4, 'Joi', '08:00', '10:00')
INSERT INTO OreProgramate (ProfesorID, MaterieID, SalaID, Zi, OraInceput, OraSfarsit)
VALUES (2, 5, 5, 'Vineri', '10:00', '12:00')
INSERT INTO OreProgramate (ProfesorID, MaterieID, SalaID, Zi, OraInceput, OraSfarsit)
VALUES (4, 6, 6, 'Luni', '14:00', '16:00')
INSERT INTO OreProgramate (ProfesorID, MaterieID, SalaID, Zi, OraInceput, OraSfarsit)
VALUES (5, 4, 4, 'Marti', '08:00', '10:00')