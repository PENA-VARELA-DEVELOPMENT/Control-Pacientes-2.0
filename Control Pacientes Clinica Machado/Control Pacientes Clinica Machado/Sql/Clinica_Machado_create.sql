USE tempdb
GO

CREATE DATABASE ClinicaMachado
GO

USE ClinicaMachado
GO

CREATE SCHEMA ControlPacientes
GO

-- tables
-- Table: Paciente
CREATE TABLE ControlPacientes.Paciente (
    Tipo varchar(10) NOT NULL,
    FechaCreacion datetime DEFAULT GETDATE(),
    Identidad varchar(15)  NOT NULL CHECK (Identidad LIKE '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9]'),
    Nombre varchar(50)  NOT NULL,  
    Apellido varchar(50)  NOT NULL,
    Edad int  NOT NULL,
    Direccion varchar(1000)  NOT NULL,
    Telefono int  NOT NULL,
    Ciudad varchar(100)  NOT NULL,
    FechaNacimineto varchar(20)  NOT NULL,
    Ocupacion varchar(100)  NOT NULL,
    Tutor varchar(200)  NOT NULL,
    Observaciones varchar(2000) NULL,
    NombreDelDoctorQueRefiere varchar(200)  NULL,
    Estado bit NOT NULL,
    CONSTRAINT Paciente_pk PRIMARY KEY  (Identidad)
);
GO

--Table: fotos pacientes
CREATE TABLE ControlPacientes.FotoPaciente 
(
    id int IDENTITY(1, 1), 
    nombre nvarchar (80) NOT NULL,
    comentario VARCHAR(2000),
    Foto image NOT NULL ,
    Paciente_Identidad varchar(15)  NOT NULL,
    CONSTRAINT FotoPaciente_pk PRIMARY KEY (id) 
)
-- Table: Citas
CREATE TABLE ControlPacientes.Citas (
    IdCita int IDENTITY(1,1),
    Fecha date  NOT NULL,
    Hora datetime  NOT NULL,
    paciente_Identidad varchar(15)  NOT NULL,
    Doctores_IdDoctor int  NOT NULL,
    CONSTRAINT Citas_pk PRIMARY KEY  (IdCita)
);
GO

-- Table: DetalleCita
CREATE TABLE ControlPacientes.DetalleCita (
    IdDetalleCita int IDENTITY(1,1),
    Citas_IdCita int  NOT NULL,
    MaterialesUsados varchar(100)  NOT NULL,
    ProcedimientoRealizado varchar(500)  NOT NULL,
    CONSTRAINT DetalleCita_pk PRIMARY KEY  (IdDetalleCita)
);
GO

-- Table: Doctores
CREATE TABLE ControlPacientes.Doctores (
    IdDoctor int IDENTITY(1,1),
    Nombre varchar(50)  NOT NULL,
    Apellido varchar(50)  NOT NULL,
    Especialidad varchar(100)  NOT NULL,
    NumeroColegiacion int  NOT NULL,
    CONSTRAINT Doctores_pk PRIMARY KEY  (IdDoctor)
);
GO

-- Table: ExamenDental
CREATE TABLE ControlPacientes.Odontogramas(
    Id_odontograma int IDENTITY(1,1),
    Diente int NOT NULL,
    Observaciones varchar(100),
    Vestibular varchar(15),
    Distal varchar(15),
    Oclusal varchar(15),
    Mesial varchar(15),
    Lingual varchar(15),
    Paciente_Identidad varchar(15)  NOT NULL,
    CONSTRAINT Odontogramas_pk PRIMARY KEY (Id_odontograma)
);
GO

-- Table: HistoriaMedica
CREATE TABLE ControlPacientes.HistoriaMedica (
    IdHistoria int IDENTITY(1,1),
    PadeceEnfermedad bit,
    TmMedico varchar(500) NOT NULL,
    TomaMedicamentos varchar(500),
    IntervenidoQuirurgicamente bit,
    HospitalizadoAlgunaVez bit,
    Alergias varchar(500)  NOT NULL,
    EnfermedadCardiaca bit  NOT NULL,
    Diabetico bit  NOT NULL,
    TuberculosisPulmonar bit  NOT NULL,
    EnfermedadHepatica bit  NOT NULL,
    ProblemasSangrado bit  NOT NULL,
    Paciente_Identidad varchar(15)  NOT NULL,
    CONSTRAINT HistoriaMedica_pk PRIMARY KEY  (IdHistoria)
);
GO

-- Table: HistorialDental
CREATE TABLE ControlPacientes.HistorialDentalOrtodoncia (
    IdHistorialD int IDENTITY(1,1),
    TratamientoDentarR bit  NOT NULL,
    Tratamiento varchar(2000)  NOT NULL,
    Paciente_Identidad varchar(15)  NOT NULL,
    CONSTRAINT HistorialDentalOrtodoncia_pk PRIMARY KEY  (IdHistorialD)
);
GO

CREATE TABLE ControlPacientes.HistorialDentalGeneral (
    IdHistorialD int IDENTITY(1,1),
    CuantasVecesCepilla int NOT NULL,
    UtilizaHiloDental bit NOT NULL,
    UsaEnjuague bit NOT NULL,
    CambiaCepilloFrecuentemente varchar(100) NOT NULL,
    VisitadoOdontologoAntes bit NOT NULL,
    TratamientosRealizados varchar(2000), --Depende de VisitadoOdontologoAntes--
    ComplicacionesAnestecia varchar(2000),
    Paciente_Identidad varchar(15) NOT NULL,
    CONSTRAINT HistorialDentalGeneral_pk PRIMARY KEY  (IdHistorialD)
);
GO

CREATE TABLE ControlPacientes.Usuarios (
    IdUsuarios int IDENTITY(1,1),
    NombreUsuario varchar(64), 
    Contraseña varchar(64),
    CONSTRAINT Usuarios_pk PRIMARY KEY  (IdUsuarios)
);
GO


-- foreign keys
-- Reference: Citas_Doctores (table: Citas)
ALTER TABLE ControlPacientes.Citas ADD CONSTRAINT Citas_Doctores
    FOREIGN KEY (Doctores_IdDoctor)
    REFERENCES ControlPacientes.Doctores (IdDoctor)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

ALTER TABLE ControlPacientes.Odontogramas ADD CONSTRAINT Odontogramas_Paciente
    FOREIGN KEY (Paciente_Identidad)
    REFERENCES ControlPacientes.Paciente (Identidad)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

ALTER TABLE ControlPacientes.HistorialDentalGeneral ADD CONSTRAINT HistorialDentalGeneral_Paciente
    FOREIGN KEY (Paciente_Identidad)
    REFERENCES ControlPacientes.Paciente (Identidad)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

-- Reference: DetalleCita_Citas (table: DetalleCita)
ALTER TABLE ControlPacientes.DetalleCita ADD CONSTRAINT DetalleCita_Citas
    FOREIGN KEY (Citas_IdCita)
    REFERENCES ControlPacientes.Citas (IdCita)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

-- Reference: HistoriaMedica_Paciente (table: HistoriaMedica)
ALTER TABLE ControlPacientes.HistoriaMedica ADD CONSTRAINT HistoriaMedica_Paciente
    FOREIGN KEY (Paciente_Identidad)
    REFERENCES ControlPacientes.Paciente (Identidad)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

-- Reference: HistorialDental_Paciente (table: HistorialDental)
ALTER TABLE ControlPacientes.HistorialDentalOrtodoncia ADD CONSTRAINT HistorialDentalOr_Paciente
    FOREIGN KEY (Paciente_Identidad)
    REFERENCES ControlPacientes.Paciente (Identidad)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

-- Reference: citas_paciente (table: Citas)
ALTER TABLE ControlPacientes.Citas ADD CONSTRAINT citas_paciente
    FOREIGN KEY (paciente_Identidad)
    REFERENCES ControlPacientes.Paciente (Identidad)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

ALTER TABLE ControlPacientes.FotoPaciente ADD CONSTRAINT FotoPaciente_Paciente
    FOREIGN KEY (Paciente_Identidad)
    REFERENCES ControlPacientes.Paciente (Identidad)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

USE [ClinicaMachado];
GO

CREATE PROC [ControlPacientes].[sp_ListarCitas] 
    @IdCita int
AS 
BEGIN

    SELECT [IdCita], [Fecha], [Hora], [paciente_Identidad], [Doctores_IdDoctor] 
    FROM   [ControlPacientes].[Citas] 
    WHERE  ([IdCita] = @IdCita OR @IdCita IS NULL) 
END
GO


CREATE PROC [ControlPacientes].[sp_NuevaCita] 
    @Fecha date,
    @Hora datetime,
    @paciente_Identidad varchar(15),
    @Doctores_IdDoctor int
AS 
BEGIN
    
    INSERT INTO [ControlPacientes].[Citas] ([Fecha], [Hora], [paciente_Identidad], [Doctores_IdDoctor])
    SELECT @Fecha, @Hora, @paciente_Identidad, @Doctores_IdDoctor
    
END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarCita] 
    @IdCita int,
    @Fecha date,
    @Hora datetime,
    @paciente_Identidad varchar(15),
    @Doctores_IdDoctor int
AS 
BEGIN

    UPDATE [ControlPacientes].[Citas]
    SET    [Fecha] = @Fecha, [Hora] = @Hora, [paciente_Identidad] = @paciente_Identidad, [Doctores_IdDoctor] = @Doctores_IdDoctor
    WHERE  [IdCita] = @IdCita
    
END
GO


CREATE PROC [ControlPacientes].[sp_EliminarCitas] 
    @IdCita int
AS 
BEGIN
    DELETE
    FROM   [ControlPacientes].[Citas]
    WHERE  [IdCita] = @IdCita
END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------

CREATE PROC [ControlPacientes].[sp_ListarDetalleCita] 
    @IdDetalleCita int
AS 
BEGIN

    SELECT [IdDetalleCita], [Citas_IdCita], [MaterialesUsados], [ProcedimientoRealizado] 
    FROM   [ControlPacientes].[DetalleCita] 
    WHERE  ([IdDetalleCita] = @IdDetalleCita OR @IdDetalleCita IS NULL) 
END
GO


CREATE PROC [ControlPacientes].[sp_NuevoDetalleCita] 
    @Citas_IdCita int,
    @MaterialesUsados varchar(100),
    @ProcedimientoRealizado varchar(500)
AS 
BEGIN
    
    INSERT INTO [ControlPacientes].[DetalleCita] ([Citas_IdCita], [MaterialesUsados], [ProcedimientoRealizado])
    SELECT @Citas_IdCita, @MaterialesUsados, @ProcedimientoRealizado
END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarDetalleCita] 
    @IdDetalleCita int,
    @Citas_IdCita int,
    @MaterialesUsados varchar(100),
    @ProcedimientoRealizado varchar(500)
AS 
BEGIN

    UPDATE [ControlPacientes].[DetalleCita]
    SET    [Citas_IdCita] = @Citas_IdCita, [MaterialesUsados] = @MaterialesUsados, [ProcedimientoRealizado] = @ProcedimientoRealizado
    WHERE  [IdDetalleCita] = @IdDetalleCita
    
END
GO


CREATE PROC [ControlPacientes].[sp_EliminarDetalleCita] 
    @IdDetalleCita int
AS 
BEGIN

    DELETE
    FROM   [ControlPacientes].[DetalleCita]
    WHERE  [IdDetalleCita] = @IdDetalleCita
END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


CREATE PROC [ControlPacientes].[sp_ListarDoctores] 
    @IdDoctor int
AS 
BEGIN

    SELECT [IdDoctor], [Nombre], [Apellido], [Especialidad], [NumeroColegiacion] 
    FROM   [ControlPacientes].[Doctores] 
    WHERE  ([IdDoctor] = @IdDoctor OR @IdDoctor IS NULL) 
END
GO


CREATE PROC [ControlPacientes].[sp_NuevoDoctores] 
    @Nombre varchar(50),
    @Apellido varchar(50),
    @Especialidad varchar(100),
    @NumeroColegiacion int
AS 
BEGIN
    
    INSERT INTO [ControlPacientes].[Doctores] ([Nombre], [Apellido], [Especialidad], [NumeroColegiacion])
    SELECT @Nombre, @Apellido, @Especialidad, @NumeroColegiacion
    
END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarDoctores] 
    @IdDoctor int,
    @Nombre varchar(50),
    @Apellido varchar(50),
    @Especialidad varchar(100),
    @NumeroColegiacion int
AS 
BEGIN

    UPDATE [ControlPacientes].[Doctores]
    SET    [Nombre] = @Nombre, [Apellido] = @Apellido, [Especialidad] = @Especialidad, [NumeroColegiacion] = @NumeroColegiacion
    WHERE  [IdDoctor] = @IdDoctor
    
END
GO


CREATE PROC [ControlPacientes].[sp_EliminarDoctores] 
    @IdDoctor int
AS 
BEGIN

    DELETE
    FROM   [ControlPacientes].[Doctores]
    WHERE  [IdDoctor] = @IdDoctor

END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


CREATE PROC [ControlPacientes].[sp_ListarFotoPaciente] 
    @id int
AS 
BEGIN

    SELECT [id], [nombre], [comentario], [Foto], [Paciente_Identidad] 
    FROM   [ControlPacientes].[FotoPaciente] 
    WHERE  ([id] = @id OR @id IS NULL) 

END
GO


CREATE PROC [ControlPacientes].[sp_NuevaFotoPaciente] 
    @nombre nvarchar(80),
    @comentario varchar(2000) = NULL,
    @Foto image,
    @Paciente_Identidad varchar(15)
AS 
BEGIN
    
    INSERT INTO [ControlPacientes].[FotoPaciente] ([nombre], [comentario], [Foto], [Paciente_Identidad])
    SELECT @nombre, @comentario, @Foto, @Paciente_Identidad
    
END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarFotoPaciente] 
    @id int,
    @nombre nvarchar(80),
    @comentario varchar(2000) = NULL,
    @Paciente_Identidad varchar(15)
AS 
BEGIN

    UPDATE [ControlPacientes].[FotoPaciente]
    SET    [nombre] = @nombre, [comentario] = @comentario, [Paciente_Identidad] = @Paciente_Identidad
    WHERE  [id] = @id
    
END
GO


CREATE PROC [ControlPacientes].[sp_EliminarFotoPaciente] 
    @id int
AS 
BEGIN

    DELETE
    FROM   [ControlPacientes].[FotoPaciente]
    WHERE  [id] = @id

END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------

CREATE PROC [ControlPacientes].[sp_ListarHistorialDentalGeneral] 
    @IdHistorialD int
AS 
BEGIN

    SELECT [IdHistorialD], [CuantasVecesCepilla], [UtilizaHiloDental], [UsaEnjuague], [CambiaCepilloFrecuentemente], [VisitadoOdontologoAntes], [TratamientosRealizados], [ComplicacionesAnestecia], [Paciente_Identidad] 
    FROM   [ControlPacientes].[HistorialDentalGeneral] 
    WHERE  ([IdHistorialD] = @IdHistorialD OR @IdHistorialD IS NULL) 

END
GO


CREATE PROC [ControlPacientes].[sp_NuevoHistorialDentalGeneral] 
    @CuantasVecesCepilla int,
    @UtilizaHiloDental bit,
    @UsaEnjuague bit,
    @CambiaCepilloFrecuentemente varchar(100),
    @VisitadoOdontologoAntes bit,
    @TratamientosRealizados varchar(2000) = NULL,
    @ComplicacionesAnestecia varchar(2000) = NULL,
    @Paciente_Identidad varchar(15)
AS 
BEGIN
    
    INSERT INTO [ControlPacientes].[HistorialDentalGeneral] ([CuantasVecesCepilla], [UtilizaHiloDental], [UsaEnjuague], [CambiaCepilloFrecuentemente], [VisitadoOdontologoAntes], [TratamientosRealizados], [ComplicacionesAnestecia], [Paciente_Identidad])
    SELECT @CuantasVecesCepilla, @UtilizaHiloDental, @UsaEnjuague, @CambiaCepilloFrecuentemente, @VisitadoOdontologoAntes, @TratamientosRealizados, @ComplicacionesAnestecia, @Paciente_Identidad
    
END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarHistorialDentalGeneral] 
    @IdHistorialD int,
    @CuantasVecesCepilla int,
    @UtilizaHiloDental bit,
    @UsaEnjuague bit,
    @CambiaCepilloFrecuentemente varchar(100),
    @VisitadoOdontologoAntes bit,
    @TratamientosRealizados varchar(2000) = NULL,
    @ComplicacionesAnestecia varchar(2000) = NULL,
    @Paciente_Identidad varchar(15)
AS 
BEGIN
    UPDATE [ControlPacientes].[HistorialDentalGeneral]
    SET    [CuantasVecesCepilla] = @CuantasVecesCepilla, [UtilizaHiloDental] = @UtilizaHiloDental, [UsaEnjuague] = @UsaEnjuague, [CambiaCepilloFrecuentemente] = @CambiaCepilloFrecuentemente, [VisitadoOdontologoAntes] = @VisitadoOdontologoAntes, [TratamientosRealizados] = @TratamientosRealizados, [ComplicacionesAnestecia] = @ComplicacionesAnestecia, [Paciente_Identidad] = @Paciente_Identidad
    WHERE  [IdHistorialD] = @IdHistorialD
END
GO


CREATE PROC [ControlPacientes].[sp_EliminarHistorialDentalGeneral] 
    @IdHistorialD int
AS 
    BEGIN
    DELETE
    FROM   [ControlPacientes].[HistorialDentalGeneral]
    WHERE  [IdHistorialD] = @IdHistorialD

    END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


CREATE PROC [ControlPacientes].[sp_ListarHistorialDentalOrtodoncia] 
    @IdHistorialD int
AS 
BEGIN

    SELECT [IdHistorialD], [TratamientoDentarR], [Tratamiento], [Paciente_Identidad] 
    FROM   [ControlPacientes].[HistorialDentalOrtodoncia] 
    WHERE  ([IdHistorialD] = @IdHistorialD OR @IdHistorialD IS NULL) 
END
GO


CREATE PROC [ControlPacientes].[sp_NuevaHistorialDentalOrtodoncia] 
    @TratamientoDentarR bit,
    @Tratamiento varchar(2000),
    @Paciente_Identidad varchar(15)
AS 
BEGIN   

    INSERT INTO [ControlPacientes].[HistorialDentalOrtodoncia] ([TratamientoDentarR], [Tratamiento], [Paciente_Identidad])
    SELECT @TratamientoDentarR, @Tratamiento, @Paciente_Identidad
               
END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarHistorialDentalOrtodoncia] 
    @IdHistorialD int,
    @TratamientoDentarR bit,
    @Tratamiento varchar(2000),
    @Paciente_Identidad varchar(15)
AS 
BEGIN
    UPDATE [ControlPacientes].[HistorialDentalOrtodoncia]
    SET    [TratamientoDentarR] = @TratamientoDentarR, [Tratamiento] = @Tratamiento, [Paciente_Identidad] = @Paciente_Identidad
    WHERE  [IdHistorialD] = @IdHistorialD
END
GO


CREATE PROC [ControlPacientes].[sp_EliminarHistorialDentalOrtodoncia] 
    @IdHistorialD int
AS 
BEGIN

    DELETE
    FROM   [ControlPacientes].[HistorialDentalOrtodoncia]
    WHERE  [IdHistorialD] = @IdHistorialD

END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


CREATE PROC [ControlPacientes].[sp_ListarHistoriaMedica] 
    @IdHistoria int
AS 
BEGIN

    SELECT [IdHistoria], [PadeceEnfermedad], [TmMedico], [TomaMedicamentos], [IntervenidoQuirurgicamente], [HospitalizadoAlgunaVez], [Alergias], [EnfermedadCardiaca], [Diabetico], [TuberculosisPulmonar], [EnfermedadHepatica], [ProblemasSangrado], [Paciente_Identidad] 
    FROM   [ControlPacientes].[HistoriaMedica] 
    WHERE  ([IdHistoria] = @IdHistoria OR @IdHistoria IS NULL) 

END
GO


CREATE PROC [ControlPacientes].[sp_NuevaHistoriaMedica] 
    @PadeceEnfermedad bit = NULL,
    @TmMedico bit,
    @TomaMedicamentos varchar(500) = NULL,
    @IntervenidoQuirurgicamente varchar(500) = NULL,
    @HospitalizadoAlgunaVez varchar(500) = NULL,
    @Alergias varchar(500),
    @EnfermedadCardiaca bit,
    @Diabetico bit,
    @TuberculosisPulmonar bit,
    @EnfermedadHepatica bit,
    @ProblemasSangrado bit,
    @Paciente_Identidad varchar(15)
AS 
BEGIN
    
    INSERT INTO [ControlPacientes].[HistoriaMedica] ([PadeceEnfermedad], [TmMedico], [TomaMedicamentos], [IntervenidoQuirurgicamente], [HospitalizadoAlgunaVez], [Alergias], [EnfermedadCardiaca], [Diabetico], [TuberculosisPulmonar], [EnfermedadHepatica], [ProblemasSangrado], [Paciente_Identidad])
    SELECT @PadeceEnfermedad, @TmMedico, @TomaMedicamentos, @IntervenidoQuirurgicamente, @HospitalizadoAlgunaVez, @Alergias, @EnfermedadCardiaca, @Diabetico, @TuberculosisPulmonar, @EnfermedadHepatica, @ProblemasSangrado, @Paciente_Identidad
    
END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarHistoriaMedica] 
    @IdHistoria int,
    @PadeceEnfermedad bit = NULL,
    @TmMedico bit,
    @TomaMedicamentos varchar(500) = NULL,
    @IntervenidoQuirurgicamente varchar(500) = NULL,
    @HospitalizadoAlgunaVez varchar(500) = NULL,
    @Alergias varchar(500),
    @EnfermedadCardiaca bit,
    @Diabetico bit,
    @TuberculosisPulmonar bit,
    @EnfermedadHepatica bit,
    @ProblemasSangrado bit,
    @Paciente_Identidad varchar(15)
AS 
BEGIN

    UPDATE [ControlPacientes].[HistoriaMedica]
    SET    [PadeceEnfermedad] = @PadeceEnfermedad, [TmMedico] = @TmMedico, [TomaMedicamentos] = @TomaMedicamentos, [IntervenidoQuirurgicamente] = @IntervenidoQuirurgicamente, [HospitalizadoAlgunaVez] = @HospitalizadoAlgunaVez, [Alergias] = @Alergias, [EnfermedadCardiaca] = @EnfermedadCardiaca, [Diabetico] = @Diabetico, [TuberculosisPulmonar] = @TuberculosisPulmonar, [EnfermedadHepatica] = @EnfermedadHepatica, [ProblemasSangrado] = @ProblemasSangrado, [Paciente_Identidad] = @Paciente_Identidad
    WHERE  [IdHistoria] = @IdHistoria

END
GO


CREATE PROC [ControlPacientes].[sp_EliminarHistoriaMedica] 
    @IdHistoria int
AS 
BEGIN

    DELETE
    FROM   [ControlPacientes].[HistoriaMedica]
    WHERE  [IdHistoria] = @IdHistoria

END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


CREATE PROC [ControlPacientes].[sp_ListarOdontogramas] 
    @Id_odontograma int
AS 
BEGIN

    SELECT [Id_odontograma], [Diente], [Observaciones], [Vestibular], [Distal], [Oclusal], [Mesial], [Lingual], [Paciente_Identidad] 
    FROM   [ControlPacientes].[Odontogramas] 
    WHERE  ([Id_odontograma] = @Id_odontograma OR @Id_odontograma IS NULL) 

END
GO


CREATE PROC [ControlPacientes].[sp_NuevaOdontogramas] 
    @Diente int,
    @Observaciones varchar(100) = NULL,
    @Vestibular varchar(15) = NULL,
    @Distal varchar(15) = NULL,
    @Oclusal varchar(15) = NULL,
    @Mesial varchar(15) = NULL,
    @Lingual varchar(15) = NULL,
    @Paciente_Identidad varchar(15)
AS 
BEGIN
    
    INSERT INTO [ControlPacientes].[Odontogramas] ([Diente], [Observaciones], [Vestibular], [Distal], [Oclusal], [Mesial], [Lingual], [Paciente_Identidad])
    SELECT @Diente, @Observaciones, @Vestibular, @Distal, @Oclusal, @Mesial, @Lingual, @Paciente_Identidad
            
END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarOdontogramas] 
    @Id_odontograma int,
    @Diente int,
    @Observaciones varchar(100) = NULL,
    @Vestibular varchar(15) = NULL,
    @Distal varchar(15) = NULL,
    @Oclusal varchar(15) = NULL,
    @Mesial varchar(15) = NULL,
    @Lingual varchar(15) = NULL,
    @Paciente_Identidad varchar(15)
AS 
BEGIN

    UPDATE [ControlPacientes].[Odontogramas]
    SET    [Diente] = @Diente, [Observaciones] = @Observaciones, [Vestibular] = @Vestibular, [Distal] = @Distal, [Oclusal] = @Oclusal, [Mesial] = @Mesial, [Lingual] = @Lingual, [Paciente_Identidad] = @Paciente_Identidad
    WHERE  [Id_odontograma] = @Id_odontograma
    
END
GO


CREATE PROC [ControlPacientes].[sp_EliminarOdontogramas] 
    @Id_odontograma int
AS 
BEGIN

    DELETE
    FROM   [ControlPacientes].[Odontogramas]
    WHERE  [Id_odontograma] = @Id_odontograma

END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


CREATE PROC [ControlPacientes].[sp_ListarPaciente] 
    @Identidad varchar(15)
AS 
BEGIN

    SELECT [Identidad], [Tipo], [FechaCreacion], [Nombre], [Apellido], [Edad], [Direccion], [Telefono], [Ciudad], [FechaNacimineto], [Ocupacion], [Tutor], [Observaciones], [NombreDelDoctorQueRefiere], [Estado] 
    FROM   [ControlPacientes].[Paciente] 
    WHERE  ([Identidad] = @Identidad OR @Identidad IS NULL) 

END
GO


CREATE PROC [ControlPacientes].[sp_NuevaPaciente] 
    @Identidad varchar(15),
    @Tipo varchar(10),
    @Nombre varchar(50),
    @Apellido varchar(50),
    @Edad int,
    @Direccion varchar(1000),
    @Telefono int,
    @Ciudad varchar(100),
    @FechaNacimineto varchar(20),
    @Ocupacion varchar(100),
    @Tutor varchar(200),
    @Observaciones varchar(2000) = NULL,
    @NombreDelDoctorQueRefiere varchar(200) = NULL,
    @Estado bit
AS 
BEGIN   

    INSERT INTO [ControlPacientes].[Paciente] ([Identidad], [Tipo], [Nombre], [Apellido], [Edad], [Direccion], [Telefono], [Ciudad], [FechaNacimineto], [Ocupacion], [Tutor], [Observaciones], [NombreDelDoctorQueRefiere], [Estado])
    SELECT @Identidad, @Tipo, @Nombre, @Apellido, @Edad, @Direccion, @Telefono, @Ciudad, @FechaNacimineto, @Ocupacion, @Tutor, @Observaciones, @NombreDelDoctorQueRefiere, @Estado

END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarPaciente] 
    @Identidad varchar(15),
    @Tipo varchar(10),
    @Nombre varchar(50),
    @Apellido varchar(50),
    @Edad int,
    @Direccion varchar(1000),
    @Telefono int,
    @Ciudad varchar(100),
    @FechaNacimineto varchar(20),
    @Ocupacion varchar(100),
    @Tutor varchar(200),
    @Observaciones varchar(2000) = NULL,
    @NombreDelDoctorQueRefiere varchar(200) = NULL,
    @Estado bit
AS 
BEGIN

    UPDATE [ControlPacientes].[Paciente]
    SET    [Tipo] = @Tipo, [Nombre] = @Nombre, [Apellido] = @Apellido, [Edad] = @Edad, [Direccion] = @Direccion, [Telefono] = @Telefono, [Ciudad] = @Ciudad, [FechaNacimineto] = @FechaNacimineto, [Ocupacion] = @Ocupacion, [Tutor] = @Tutor, [Observaciones] = @Observaciones, [NombreDelDoctorQueRefiere] = @NombreDelDoctorQueRefiere, [Estado] = @Estado
    WHERE  [Identidad] = @Identidad

END
GO


CREATE PROC [ControlPacientes].[sp_EliminarPaciente] 
    @Identidad varchar(15)
AS 
BEGIN

    DELETE
    FROM   [ControlPacientes].[Paciente]
    WHERE  [Identidad] = @Identidad

END
GO

----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


CREATE PROC [ControlPacientes].[sp_ListarUsuarios] 
    @IdUsuarios int
AS 
BEGIN

    SELECT [IdUsuarios], [NombreUsuario], [Contraseña] 
    FROM   [ControlPacientes].[Usuarios] 
    WHERE  ([IdUsuarios] = @IdUsuarios OR @IdUsuarios IS NULL) 
END
GO


CREATE PROC [ControlPacientes].[sp_NuevoUsuarios] 
    @NombreUsuario varchar(64) = NULL,
    @Contraseña varchar(64) = NULL
AS 
BEGIN
    
    INSERT INTO [ControlPacientes].[Usuarios] ([NombreUsuario], [Contraseña])
    SELECT @NombreUsuario, @Contraseña
    
END
GO


CREATE PROC [ControlPacientes].[sp_ActualizarUsuarios] 
    @IdUsuarios int,
    @NombreUsuario varchar(64) = NULL,
    @Contraseña varchar(64) = NULL
AS 
BEGIN

    UPDATE [ControlPacientes].[Usuarios]
    SET    [NombreUsuario] = @NombreUsuario, [Contraseña] = @Contraseña
    WHERE  [IdUsuarios] = @IdUsuarios
    
END
GO


CREATE PROC [ControlPacientes].[sp_EliminarUsuarios] 
    @IdUsuarios int
AS 
BEGIN

    DELETE
    FROM   [ControlPacientes].[Usuarios]
    WHERE  [IdUsuarios] = @IdUsuarios

END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


-- End of file.

