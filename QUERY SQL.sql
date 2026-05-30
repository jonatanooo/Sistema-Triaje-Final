CREATE DATABASE TriajeClinico;
GO
USE TriajeClinico;

CREATE TABLE Usuarios
(
ID_Usuario INT not null Primary Key identity(1,1),
DUI_Usuaio varchar(10) not null unique,
Nombres varchar(200),
Apellidos varchar(200),
Rol varchar(15) CHECK(Rol IN ('Doctor','Enfermera')),
Username varchar(30) unique,
Password_Hash varchar(200)
-- Hash para agregarle un encriptado a las contraseñas
)

CREATE TABLE Pacientes
(
ID_Paciente INT not null Primary Key identity(1,1),
DUI_Paciente varchar(10) null,
Nombres varchar(200),
Apellidos varchar(200),
Fecha_Nacimiento date,
Genero varchar(15) CHECK(Genero IN ('Masculino','Femenino'))
)

CREATE TABLE Niveles_Triaje
(
ID_Nivel INT not null Primary Key identity(1,1),
Color varchar(20) unique CHECK(Color IN ('Rojo','Naranja','Amarillo','Verde','Azul')),
Descripcion varchar(255),
Tiempo_Max_Espera INT
)

CREATE TABLE Registros_Triaje
(
ID_Registro INT not null Primary Key identity(1,1),
ID_Paciente INT Foreign Key REFERENCES Pacientes(ID_Paciente),
ID_Usuario_Enfermera INT Foreign Key REFERENCES Usuarios(ID_Usuario),
FechaHora_Ingreso datetime,
Motivo_Consulta varchar(500),
Estado_Mental varchar(100),
Mecanismo_Lesion varchar(100),
Sintomas_Criticos_JSON nvarchar(max),
Temperatura DECIMAL(4,1),
Nivel_Dolor INT,
Saturacion_O2 INT,
Tiempo_Evolucion INT,
ID_NivelAsignado INT Foreign Key REFERENCES Niveles_Triaje(ID_Nivel),
Estado_Atencion varchar(20) CHECK(Estado_Atencion IN ('En Sala de Espera','Atendido','Abandono')),
ID_Usuario_Medico INT null Foreign Key REFERENCES Usuarios(ID_Usuario),
FechaHora_Atencion datetime null,
Observaciones varchar(500) null
)

INSERT INTO Niveles_Triaje
VALUES 
('Rojo','Riesgo Vital Inmediato','0'),
('Naranja','Muy Urgente','15'),
('Amarillo','Urgente','60'),
('Verde','Normal','120'),
('Azul','No Urgente','240')

SELECT T1.ID_Registro, T2.Nombres,T2.Apellidos,T1.ID_NivelAsignado,T1.FechaHora_Ingreso,T1.Motivo_Consulta,T1.Estado_Mental,T1.Mecanismo_Lesion,T1.Temperatura,T1.Nivel_Dolor,T1.Saturacion_O2,T1.Estado_Atencion
FROM Registros_Triaje AS T1
LEFT JOIN Pacientes AS T2 ON T1.ID_Paciente = T2.ID_Paciente



SELECT 
select * from Usuarios