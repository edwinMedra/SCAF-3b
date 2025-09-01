-- base de datos para proyecto SCAF
-- ================================================
-- Script completo para Base de Datos SCAF
-- ================================================

-- 1️⃣ Tabla Usuarios
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY PRIMARY KEY,
    NombreUsuario NVARCHAR(50) NOT NULL,
    Correo NVARCHAR(100) NOT NULL,
    ContraseñaHash NVARCHAR(255) NOT NULL,
    Rol NVARCHAR(20) NOT NULL CHECK (Rol IN ('Administrador','Usuario'))
);

-- 2️⃣ Tabla BitacoraSesiones
CREATE TABLE BitacoraSesiones (
    IdSesion INT IDENTITY PRIMARY KEY,
    IdUsuario INT NOT NULL FOREIGN KEY REFERENCES Usuarios(IdUsuario),
    FechaHoraInicio DATETIME NOT NULL DEFAULT GETDATE(),
    DireccionIP NVARCHAR(50)
);

-- 3️⃣ Tabla BitacoraConsultas
CREATE TABLE BitacoraConsultas (
    IdConsulta INT IDENTITY PRIMARY KEY,
    IdUsuario INT NOT NULL FOREIGN KEY REFERENCES Usuarios(IdUsuario),
    FechaHora DATETIME NOT NULL DEFAULT GETDATE(),
    DescripcionConsulta NVARCHAR(255)
);

-- 4️⃣ Tabla Padres
CREATE TABLE Padres (
    IdPadre INT IDENTITY PRIMARY KEY,
    NombreCompleto NVARCHAR(100) NOT NULL,
    DocumentoIdentidad NVARCHAR(20) NOT NULL,
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100)
);

-- 5️⃣ Tabla NivelesEducativos
CREATE TABLE NivelesEducativos (
    IdNivel INT IDENTITY PRIMARY KEY,
    NombreNivel NVARCHAR(50),
    Seccion NVARCHAR(20),
    AñoLectivo NVARCHAR(20)
);

-- 6️⃣ Tabla Alumnos
CREATE TABLE Alumnos (
    IdAlumno INT IDENTITY PRIMARY KEY,
    Carnet NVARCHAR(20) NOT NULL,
    NombreCompleto NVARCHAR(100) NOT NULL,
    FechaNacimiento DATE,
    IdNivelActual INT FOREIGN KEY REFERENCES NivelesEducativos(IdNivel)
);

-- 7️⃣ Tabla HistorialNiveles
CREATE TABLE HistorialNiveles (
    IdHistorial INT IDENTITY PRIMARY KEY,
    IdAlumno INT NOT NULL FOREIGN KEY REFERENCES Alumnos(IdAlumno),
    IdNivel INT NOT NULL FOREIGN KEY REFERENCES NivelesEducativos(IdNivel),
    AñoLectivo NVARCHAR(20)
);

-- 8️⃣ Tabla RelPadresAlumnos (Muchos a muchos)
CREATE TABLE RelPadresAlumnos (
    IdRelacion INT IDENTITY PRIMARY KEY,
    IdPadre INT NOT NULL FOREIGN KEY REFERENCES Padres(IdPadre),
    IdAlumno INT NOT NULL FOREIGN KEY REFERENCES Alumnos(IdAlumno)
);

-- 9️⃣ Tabla Eventos
CREATE TABLE Eventos (
    IdEvento INT IDENTITY PRIMARY KEY,
    NombreEvento NVARCHAR(100),
    Fecha DATETIME,
    Lugar NVARCHAR(100),
    Descripcion NVARCHAR(255)
);

-- 🔟 Tabla Asistencias
CREATE TABLE Asistencias (
    IdAsistencia INT IDENTITY PRIMARY KEY,
    IdEvento INT NOT NULL FOREIGN KEY REFERENCES Eventos(IdEvento),
    IdPadre INT NOT NULL FOREIGN KEY REFERENCES Padres(IdPadre),
    IdAlumno INT NOT NULL FOREIGN KEY REFERENCES Alumnos(IdAlumno),
    FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    Estado NVARCHAR(20) NOT NULL CHECK (Estado IN ('Presente','Ausente','Justificado'))
);
