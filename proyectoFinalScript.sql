-- Creacion de tablas --
-- use BD_tpF --

CREATE TABLE Alumnos (nro_legajo_a INT PRIMARY KEY NOT NULL,
ape_nom NCHAR(30),
nro_doc INT,
direccion NCHAR(50),
email NCHAR(20),
telefono NCHAR(20),
cod_doc NCHAR(5),
sexo NCHAR(1),
fec_nac DATETIME,
est_civil NCHAR(10));
CREATE TABLE Profesores (nro_legajo_p INT PRIMARY KEY NOT NULL,
ape_nom NCHAR(30),
nro_doc INT,
cod_doc NCHAR(5),
direccion NCHAR(50),
email NCHAR(20),
telefono NCHAR(20),
sexo NCHAR(1),
fec_nac DATETIME,
est_civil NCHAR(10),
cod_titulo NCHAR(5));
CREATE TABLE Examenes (
nro_examen INT PRIMARY KEY,
nro_legajo_a INT NOT NULL,
cod_mat NCHAR(5) NOT NULL,
cod_turno NCHAR(5) NOT NULL,
año NCHAR(4) NOT NULL,
nota INT,
fecha_inscripcion DATETIME, );
CREATE TABLE Materias (cod_materia NCHAR(5) PRIMARY KEY NOT NULL,
desc_mat NCHAR(30),
desc_carrera NCHAR(30),
nro_legajo_p INT NOT NULL, );
CREATE TABLE TipoDoc (cod_doc NCHAR(5) PRIMARY KEY NOT NULL,
desc_doc NCHAR(20));
CREATE TABLE Titulos (cod_titulo NCHAR(5) PRIMARY KEY NOT NULL,
desc_titulo NCHAR(50));
CREATE TABLE Turnos (cod_turno NCHAR(5) PRIMARY KEY NOT NULL,
desc_turno NCHAR(20));
CREATE TABLE Planificacion (cod_mat NCHAR(5) NOT NULL,
cod_turno NCHAR(5) NOT NULL,
año NCHAR(4) NOT NULL,
fecha_examen DATETIME,
PRIMARY KEY(cod_mat, cod_turno, año));

-- Creacion de relaciones --
ALTER TABLE Alumnos ADD FOREIGN KEY(cod_doc)REFERENCES TipoDoc(cod_doc);
ALTER TABLE Profesores
ADD FOREIGN KEY(cod_titulo)REFERENCES Titulos(cod_titulo), FOREIGN KEY(cod_doc)REFERENCES TipoDoc(cod_doc);
ALTER TABLE Examenes
ADD FOREIGN KEY(nro_legajo_a)REFERENCES Alumnos(nro_legajo_a), FOREIGN KEY(cod_mat)REFERENCES Materias(cod_materia), FOREIGN KEY(cod_turno)REFERENCES Turnos(cod_turno);
ALTER TABLE Materias
ADD FOREIGN KEY(nro_legajo_p)REFERENCES Profesores(nro_legajo_p);
ALTER TABLE Planificacion
ADD FOREIGN KEY(cod_mat)REFERENCES Materias(cod_materia), FOREIGN KEY(cod_turno)REFERENCES Turnos(cod_turno);

-- Insert de datos --
-- Titulos --
INSERT INTO Titulos(cod_titulo, desc_titulo)VALUES('TI001', 'INGENIERO');
INSERT INTO Titulos(cod_titulo, desc_titulo)VALUES('TI002', 'ABOGADO');
INSERT INTO Titulos(cod_titulo, desc_titulo)VALUES('TI003', 'MEDICO');
INSERT INTO Titulos(cod_titulo, desc_titulo)VALUES('TI004', 'ARQUITECTO');
INSERT INTO Titulos(cod_titulo, desc_titulo)VALUES('TI005', 'CONTADOR');
INSERT INTO Titulos(cod_titulo, desc_titulo)
VALUES('TI006 ', 'ANALISTA DE SISTEMAS');
INSERT INTO Titulos(cod_titulo, desc_titulo)VALUES('TI007', 'RRHH');
INSERT INTO Titulos(cod_titulo, desc_titulo)VALUES('TI008', 'MAESTRO');
INSERT INTO Titulos(cod_titulo, desc_titulo)
VALUES('TI009', 'DISEÑADOR GRAFICO');
INSERT INTO Titulos(cod_titulo, desc_titulo)
VALUES('TI010', 'DISEÑADOR DE INTERIORES');

-- Turnos --
INSERT INTO Turnos(cod_turno, desc_turno)VALUES('TN001', 'MARZO');
INSERT INTO Turnos(cod_turno, desc_turno)VALUES('TN002', 'JUNIO');
INSERT INTO Turnos(cod_turno, desc_turno)VALUES('TN003', 'SEPTIEMBRE');
INSERT INTO Turnos(cod_turno, desc_turno)VALUES('TN004', 'DICIEMBRE');

-- TipoDoc --
INSERT INTO TipoDoc(cod_doc, desc_doc)VALUES('TD001', 'DNI');
INSERT INTO TipoDoc(cod_doc, desc_doc)VALUES('TD002', 'LE');
INSERT INTO TipoDoc(cod_doc, desc_doc)VALUES('TD003', 'PASAPORTE');
INSERT INTO TipoDoc(cod_doc, desc_doc)VALUES('TD004', 'CE');
INSERT INTO TipoDoc(cod_doc, desc_doc)VALUES('TD005', 'OTROS');

-- Alumnos --
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(1, 'LOPEZ LUIS', 12345567, 'LOPLUIS@DATA', '03461456789', 'TD001', 'M', '07/09/1990', 'CASADO');
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(2, 'LOPEZ SABRINA', 17169789, 'LOSA789@DATA', '03461404789', 'TD001', 'F', '17/10/1998', 'SOLTERA');
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(3, 'GOMEZ LAURA', 17168889, 'GOMEZ.LAURA@DATA', '03461404888', 'TD001', 'F', '30/06/1964', 'CASADA');
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(4, 'VASAVILVASO REBERTO', 25169789, 'VASAVIL@DATA', '03461645789', 'TD001', 'M', '27/08/2001', 'CASADO');
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(5, 'PIEDRABUENA ELIO', 2716999, 'PIEDRA.BUENA@DATA', '0346145666', 'TD004', 'M', '17/02/2001', 'CASADO');
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(6, 'LOPEZ LUISINA', 12345567, 'PLUISANA@DATA', '03461222689', 'TD002', 'F', '07/09/1990', 'CASADA');
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(7, 'SANTORO ADRIANA', 26169789, 'SANADRIANA@DATA', '03461404789', 'TD001', 'F', '17/10/1998', 'SOLTERA');
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(8, 'GONZALEZ LORENZO', 17166666, 'GOLO@DATA', '0346140777', 'TD005', 'M', '30/07/1965', 'SOLTERO');
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(9, 'VASAVILVASO ANABEL', 26169789, 'VASANA@DATA', '03464445789', 'TD005', 'F', '27/06/2002', 'SOLTERA');
INSERT INTO Alumnos(nro_legajo_a, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil)
values(10, 'PIEDRABUENA ELIO', 2716999, 'PIEDRA.BUENA@DATA', '0346145666', 'TD004', 'M', '17/02/2001', 'CASADO');

-- Profesores --
INSERT INTO Profesores(nro_legajo_p, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil, cod_titulo)
values(1, 'SALERNO LUIS', 45056894, 'SALERNOLUIS@DATA', '03461456789', 'TD001', 'M', '07/09/1990', 'CASADO', 'TI001');
INSERT INTO Profesores(nro_legajo_p, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil, cod_titulo)
values(2, 'ZURITA SABRINA', 18169789, 'SURITA789@DATA', '03461404789', 'TD001', 'F', '17/10/1998', 'SOLTERA', 'TI002');
INSERT INTO Profesores(nro_legajo_p, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil, cod_titulo)
values(3, 'BERTOLO LAURA', 34168889, 'BNERTO.LAURA@DATA', '03461404888', 'TD001', 'F', '30/06/1964', 'CASADA', 'TI003');
INSERT INTO Profesores(nro_legajo_p, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil, cod_titulo)
values(4, 'CANDIDO REBERTO', 18169789, 'CANDIDO@DATA', '03461645789', 'TD001', 'M', '27/08/2001', 'CASADO', 'TI004');
INSERT INTO Profesores(nro_legajo_p, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil, cod_titulo)
values(5, 'SANGSOTO ELIO', 4216999, 'SANGSOTO@DATA', '0346145666', 'TD004', 'M', '17/02/2001', 'CASADO', 'TI005');
INSERT INTO Profesores(nro_legajo_p, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil, cod_titulo)
values(6, 'LOPETRE LUISINA', 12345567, 'LOLUISANA@DATA', '03461222689', 'TD002', 'F', '07/09/1990', 'CASADA', 'TI007');
INSERT INTO Profesores(nro_legajo_p, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil, cod_titulo)
values(7, 'SANANTONIO ADRIANA', 46169789, 'SANANTONIO@DATA', '03461404789', 'TD001', 'F', '17/10/1998', 'SOLTERA', 'TI008');
INSERT INTO Profesores(nro_legajo_p, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil, cod_titulo)
values(8, 'GONZALEZ ERNESTO', 1717777, 'GONESTO@DATA', '0346140777', 'TD005', 'M', '30/07/1965', 'SOLTERO', 'TI009');
INSERT INTO Profesores(nro_legajo_p, ape_nom, nro_doc, email, telefono, cod_doc, sexo, fec_nac, est_civil, cod_titulo)
values(9, 'VAS  ANABELA', 14169789, 'VASANBELA@DATA', '03464445789', 'TD005', 'F', '27/06/2002', 'SOLTERA', 'TI010');

-- Materias --
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA001', 'ANALISIS MATEMATICO', 'INGENIERIA', 1);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA002', 'MECANICA', 'INGENIERIA', 1);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA003', 'DIBUJO TECNICO', 'INGENIERIA', 4);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA004', 'CALCULO NUMERICO', 'INGENIERIA', 8);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA005', 'CIRUGIA', 'MEDICINA', 3);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA006', 'ANTOMIA', 'MEDICINA', 3);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA007', 'BIOLOGIA', 'MEDICINA', 3);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA008', 'FAMACIA', 'MEDICINA', 3);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA017', 'ESTADOS CONTABLES', 'CIENCIA ECONOMICA', 5);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA018', 'IMPUESTOS', 'CIENCIA ECONOMICA', 7);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA019', 'FINANZAS', 'CIENCIA ECONOMICA', 8);
INSERT INTO Materias(cod_materia, desc_mat, desc_carrera, nro_legajo_p)
values('MA020', 'BALANCE FINANCIERO', 'CIENCIA ECONOMICA', 9);

-- Examenes --
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(1, 1, 'MA001', 'TN001', '2009', 6, '26/03/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(2, 1, 'MA001', 'TN002', '2009', 7, '26/06/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(3, 1, 'MA002', 'TN003', '2009', NULL, '30/06/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(4, 1, 'MA003', 'TN004', '2009', NULL, '30/06/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(5, 2, 'MA005', 'TN001', '2009', 8, '04/03/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(6, 2, 'MA006', 'TN002', '2009', 9, '07/08/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(7, 2, 'MA007', 'TN003', '2009', NULL, '30/06/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(8, 2, 'MA008', 'TN004', '2009', NULL, '16/09/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(9, 3, 'MA017', 'TN001', '2009', 4, '04/03/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(10, 3, 'MA017', 'TN002', '2009', 4, '11/06/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(11, 3, 'MA017', 'TN003', '2009', NULL, '07/08/2009');
INSERT INTO Examenes(nro_examen, nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)
VALUES(12, 3, 'MA018', 'TN004', '2009', NULL, '07/08/2009');

-- Planificacion --
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA001', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA002', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA003', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA004', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA005', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA006', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA007', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA008', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA017', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA018', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA019', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA020', 'TN001', '2009', '27/03/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA001', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA002', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA003', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA004', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA005', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA006', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA007', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA008', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA017', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA018', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA019', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA020', 'TN002', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA001', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA002', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA003', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA004', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA005', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA006', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA007', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA008', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA017', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA018', 'TN003', '2009', '27/06/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA019', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA020', 'TN003', '2009', '27/09/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA001', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA002', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA003', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA004', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA005', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA006', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA007', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA008', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA017', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA018', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA019', 'TN004', '2009', '27/12/2009');
INSERT INTO Planificacion(cod_mat, cod_turno, año, fecha_examen)
VALUES('MA020', 'TN004', '2009', '27/12/2009');

-- Modificaciones --
alter table alumnos alter column ape_nom nvarchar(255)
alter table alumnos alter column email nvarchar(255)
alter table alumnos alter column telefono nvarchar(128)


alter table profesores alter column ape_nom nvarchar(255)
alter table profesores alter column email nvarchar(255)
alter table profesores alter column telefono nvarchar(128)

--CREAR PROCEDURES DE A UNO--
create procedure alumnosPorTurnos AS 
SELECT p.cod_turno, t.desc_turno, m.cod_materia, m.desc_mat, a.nro_legajo_a, a.ape_nom
FROM Planificacion p
JOIN Materias m ON p.cod_mat = m.cod_materia
JOIN Examenes e ON p.cod_mat = e.cod_mat AND p.cod_turno = e.cod_turno
JOIN Alumnos a ON e.nro_legajo_a = a.nro_legajo_a
JOIN Turnos t ON p.cod_turno = t.cod_turno
ORDER BY p.cod_turno, m.cod_materia, a.nro_legajo_a;

create procedure contarAlumnosPorTurnos AS
SELECT p.cod_turno, t.desc_turno, COUNT(DISTINCT e.nro_legajo_a) AS total_alumnos
FROM Planificacion p
JOIN Examenes e ON p.cod_mat = e.cod_mat AND p.cod_turno = e.cod_turno
JOIN Turnos t ON p.cod_turno = t.cod_turno
GROUP BY p.cod_turno, t.desc_turno
ORDER BY p.cod_turno;

create procedure porcentajeAprobados AS
SELECT PL.cod_turno, T.desc_turno,
       COUNT(DISTINCT CASE WHEN E.nota >= 7 THEN E.nro_legajo_a ELSE NULL END) AS aprobados,
       COUNT(DISTINCT E.nro_legajo_a) AS total_alumnos,
       ROUND(COUNT(DISTINCT CASE WHEN E.nota >= 7 THEN E.nro_legajo_a ELSE NULL END) * 100.0 / COUNT(DISTINCT E.nro_legajo_a), 2) AS porcentaje_aprobados
FROM Planificacion PL
LEFT JOIN Examenes E ON PL.cod_turno = E.cod_turno AND PL.año = E.año
JOIN Turnos T ON PL.cod_turno = T.cod_turno
GROUP BY PL.cod_turno, T.desc_turno;
 
create procedure turnosDetallados AS
SELECT PL.cod_turno, T.desc_turno, M.desc_mat, CONCAT(PF.ape_nom, ' ', PF.nro_legajo_p) AS profesor, PL.fecha_examen
FROM Planificacion PL
JOIN Turnos T ON PL.cod_turno = T.cod_turno
JOIN Materias M ON PL.cod_mat = M.cod_materia
JOIN Profesores PF ON M.nro_legajo_p = PF.nro_legajo_p
JOIN Examenes E ON PL.cod_mat = E.cod_mat AND PL.cod_turno = E.cod_turno AND PL.año = E.año
ORDER BY PL.cod_turno, PL.fecha_examen;






