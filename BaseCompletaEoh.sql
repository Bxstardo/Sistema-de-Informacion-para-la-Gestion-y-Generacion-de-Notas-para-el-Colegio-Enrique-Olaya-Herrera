
Create database NotasEOH2;


Use NotasEOH2;

--TABLES--

create table Sesion
(
Id_Sesion int Primary key identity(1,1),
Usuario int,
Tipo_Usuario varchar(50),
Contraseña varchar(50)
);

create table Estudiante
(
IdentificacionEst int primary key,
Nombres varchar(50),
Apellidos varchar(50),
Direccion varchar(50),
Eps varchar(50),
Email varchar(50),
Jornada varchar(20),
Num_Contacto varchar(30),
Estado varchar(15),
IdentificacionAcu int,
Id_Curso int,
Id_Sesion int
);

Create table Acudiente
(
IdentificacionAcu int primary key,
Nombres varchar(50),
Apellidos varchar(50),
Direccion varchar(50),
Eps varchar(50),
Email varchar(50),
Num_Contacto varchar(30),
Estado varchar(15),
Id_Sesion int
);
 
Create table Administrador
(
IdentificacionAdm int primary key,
Nombres varchar(50),
Apellidos varchar(50),
Direccion varchar(50),
Eps varchar(50),
Email varchar(50),
Num_Contacto varchar(30),
Estado varchar(15),
Id_Sesion int
);

Create table Docente
(
IdentificacionDoc int primary key,
Nombres varchar(50),
Apellidos varchar(50),
Direccion varchar(50),
Eps varchar(50),
Email varchar(50),
Profesion varchar(50),
Jornada varchar(20),
Num_Contacto varchar(30),
Estado varchar(15),
Id_Curso int,
Id_Sesion int
);

Create table Curso
(
Id_Curso int primary key identity(1,1),
Num_Curso varchar(10),
Nivel varchar(30),
Jornada varchar (20),
);

Create table Notas
(
Id_Notas int primary key identity(1,1),
Nota int,
Periodo varchar(25),
Corte varchar(25),
Id_Asignaciones int,
IdentificacionEst int
);


Create table Asignaciones
(
Id_Asignaciones int primary key identity(1,1),
Id_Curso int ,
Id_Asignatura int,
IdentificacionDoc int
);

Create table Asignatura
(	
Id_Asignatura int primary key identity(1,1),
Nombre varchar(50),
Id_Area int
);

Create table Area
(
Id_Area int primary key identity(1,1),
Nombre varchar(50)
);

Create table AsignacionAsignatura
(
Id_AsignacionAsignatura int primary key identity (1,1),
IdentificacionDoc int,
Id_Asignatura int
)

--CONSTRAIN--


alter table AsignacionAsignatura add 
Constraint FK_Docente_AsignacionAsignatura
Foreign key (IdentificacionDoc)
References Docente(IdentificacionDoc)

alter table AsignacionAsignatura add 
Constraint FK_Asignatura_AsignacionAsignatura
Foreign key (Id_Asignatura)
References Asignatura(Id_Asignatura)


alter table Docente add
Constraint FK_Docente_Curso
Foreign key (Id_Curso)
References Curso(Id_Curso)

alter table Administrador add
Constraint FK_Administrador_Colegio
Foreign key (Id_Sesion)
References Sesion(Id_Sesion)


alter table Estudiante add
Constraint FK_Estudiante_Colegio
Foreign key (Id_Sesion)
References Sesion(Id_Sesion)


alter table Acudiente add
Constraint FK_Acudiente_Colegio
Foreign key (Id_Sesion)
References Sesion(Id_Sesion)


alter table Docente add
Constraint FK_Docente_Colegio
Foreign key (Id_Sesion)
References Sesion(Id_Sesion)


alter table Notas add
Constraint FK_Notas_Estudiante
Foreign key(IdentificacionEst)
References Estudiante(IdentificacionEst)


alter table Asignaciones add
Constraint FK_Curso_Asignaciones
Foreign key(Id_Curso)
References Curso(Id_Curso)


alter table Asignaciones add
Constraint FK_Asignatura_Asignaciones
Foreign key(Id_Asignatura)
References Asignatura(Id_Asignatura)


alter table Asignaciones add
Constraint FK_Docente_Asignaciones
Foreign key(IdentificacionDoc)
References Docente(IdentificacionDoc)


alter table Notas add
Constraint FK_Notas_Asignaciones
Foreign key(Id_Asignaciones)
references Asignaciones(Id_Asignaciones)


alter table Estudiante add
Constraint FK_Estudiante_Curso
Foreign key (Id_Curso)
References Curso(Id_Curso)


alter table Asignatura add
Constraint FK_Asignatura_Area
Foreign key (Id_Area)
References Area(Id_Area)


alter table Estudiante add
Constraint FK_Estudiante_Acudiente
Foreign key(IdentificacionAcu)
References Acudiente(IdentificacionAcu)
go


--PRODECURES--
--Asignaciones--


Create procedure InsertarAsignacion
@IdentificacionEst int,
@Asignatura varchar (50),
@IdentificacionDoc int

as begin 

if not exists (Select * from Asignaciones where IdentificacionDoc = @IdentificacionDoc and Id_Curso =(Select Id_Curso from Estudiante where IdentificacionEst = @IdentificacionEst) and Id_Asignatura = (Select Id_Asignatura from Asignatura where Nombre = @Asignatura) )

insert into Asignaciones
(
Id_Curso,
Id_Asignatura,
IdentificacionDoc
)
values
(
(Select Id_Curso from Estudiante where IdentificacionEst = @IdentificacionEst),
(Select Id_Asignatura from Asignatura where Nombre = @Asignatura),
@IdentificacionDoc
)


end
go


CREATE PROCEDURE ConsultarAsignacion
  @Valor varchar(50), 
  @Valor2 varchar(50),
  @Valor3 varchar(50),
  @Columna varchar(50) 
 
AS BEGIN 
 
IF @Columna = 'Id_Asignaciones'  SELECT Id_Asignaciones FROM Asignaciones WHERE Id_Curso = (Select Id_Curso from Estudiante where IdentificacionEst = @Valor) and Id_Asignatura =  (Select Id_Asignatura from Asignatura where Nombre = @Valor2) and IdentificacionDoc = @Valor3;

End 
go

--Notas--
 

Create procedure InsertarNotas
@Nota int,
@Periodo varchar(25),
@Corte varchar(25),
@Id_Asignaciones int,
@IdentificacionEst int

as begin 

if not exists (select * from Notas where @Periodo = Periodo and @Corte = Corte and @Id_Asignaciones = Id_Asignaciones and @IdentificacionEst = IdentificacionEst )

insert into Notas 
(
Nota,
Periodo,
Corte,
Id_Asignaciones,
IdentificacionEst
)
values
(
@Nota,
@Periodo,
@Corte,
@Id_Asignaciones,
@IdentificacionEst
)

else

update Notas set 
Nota = @Nota
where Id_Notas = (select Id_Notas from Notas where @Periodo = Periodo and @Corte = Corte and @Id_Asignaciones = Id_Asignaciones and @IdentificacionEst = IdentificacionEst)

end
go


--Administrador-- 

CREATE PROCEDURE ConsultarAdministrador
  @Valor varchar(50), 
  @Columna varchar(50) 
 
AS BEGIN 
 
IF @Columna = 'IdentificacionAdm'   SELECT * FROM Administrador    WHERE IdentificacionAdm=@Valor 
 
Else IF @Columna = 'Nombres'   SELECT * FROM Administrador WHERE Nombres like  @Valor + '%' 
 
Else IF @Columna = 'Apellidos'   SELECT * FROM Administrador WHERE Apellidos like  @Valor + '%' 

Else IF @Columna = 'Direccion'   SELECT * FROM Administrador  WHERE Direccion like  @Valor + '%' 

Else IF @Columna = 'Eps'   SELECT * FROM Administrador  WHERE Eps like  @Valor + '%' 

Else IF @Columna = 'Email'   SELECT * FROM Administrador WHERE Email like  @Valor + '%' 

Else IF @Columna = 'Num_Contacto'   SELECT * FROM Administrador  WHERE Num_Contacto like  @Valor + '%' 

Else if @Columna = 'Estado' Select * From Administrador WHERE Estado like @Valor + '%'


End 
go

--AG--

Create procedure InsertarAS
@IdentificacionDoc int,
@Asignatura varchar(50)

as begin

if not exists (Select * from AsignacionAsignatura where @IdentificacionDoc= IdentificacionDoc and (Select Id_Asignatura from Asignatura where @Asignatura = Nombre) = Id_Asignatura  ) 


insert into AsignacionAsignatura
(
IdentificacionDoc,
Id_Asignatura
)

values
(
@IdentificacionDoc,
(Select Id_Asignatura from Asignatura where @Asignatura = Nombre)
)


end
go

Create procedure EliminarAS
@IdentificacionDoc int,
@Asignatura varchar(50)

as begin 

Delete from AsignacionAsignatura Where IdentificacionDoc = @IdentificacionDoc and Id_Asignatura =  (Select Id_Asignatura from Asignatura where @Asignatura = Nombre)

end
go


--Area--

Create procedure InsertarArea
@Nombre varchar (50)

as begin

insert into Area
(
Nombre
)

values
(
@Nombre
)

end
go

CREATE PROCEDURE ConsultarArea
  @Valor varchar(30),
  @Columna varchar (50)
 
AS BEGIN 
 
if @Columna =  'Nombre' Select * from Area Where @Valor = Nombre 

End 
go
;


Create procedure ModificarArea
@Area varchar(50),
@Nombre varchar(50)

as begin

update Area set Nombre = @Nombre where Nombre= @Area

end
go


create procedure EliminarArea
@Nombre varchar(50)

as begin

delete from Area where @Nombre = Nombre

end
go

Create Procedure ConsultarAS
@IdentificacionDoc int

as begin

select A.Nombre as Asignatura from Docente as D 
inner join AsignacionAsignatura As AA on AA.IdentificacionDoc = D.IdentificacionDoc 
inner join Asignatura as A on A.Id_Asignatura = AA.Id_Asignatura Where D.Estado = 'Activo' and D.IdentificacionDoc = @IdentificacionDoc order by A.Nombre 

end
go

   
--Asignatura--

Create procedure InsertarAsignatura
@Nombre varchar (50)

as begin

insert into Asignatura
(
Nombre
)




values
(
@Nombre
)

end
go


CREATE PROCEDURE ConsultarAsignatura
  @Valor varchar(30),
  @Columna varchar (50)
 
AS BEGIN 
 
if @Columna =  'Nombre' Select * from Asignatura Where @Valor = Nombre 

End 
go
;

Create procedure AsignarArea
@NombreArea varchar(50),
@NombreAsignatura varchar(50)

as begin 

Update Asignatura set Id_Area = (Select Id_Area from Area where @NombreArea = Nombre)
 where (Select Id_Asignatura from Asignatura where @NombreAsignatura= Nombre) = Id_Asignatura

end
go

Create procedure ModificarAsignatura
@Asignatura varchar(50),
@Nombre varchar(50)

as begin

update Asignatura set Nombre = @Nombre where Nombre= @Asignatura

end
go

create procedure EliminarAsignatura
@Nombre varchar(50)

as begin

update Asignatura set Id_Area = NULL

delete from Asignatura where @Nombre = Nombre

end
go

--Docente--

CREATE PROCEDURE [dbo].[InsertarDocente]   
@IdentificacionDoc int,
@Nombres varchar(50),
@Apellidos varchar(50),
@Direccion varchar(50),
@Eps varchar(50),
@Email varchar(50),
@Profesion varchar(50),
@Jornada varchar(50),
@Num_Contacto varchar(30)

AS BEGIN 
 
INSERT INTO Docente     
(
IdentificacionDoc     
,Nombres            
,Apellidos            
,Direccion            
,Eps
,Email
,Profesion
,Jornada
,Num_Contacto
,Estado
)      
VALUES            
(
@IdentificacionDoc,
@Nombres,
@Apellidos,
@Direccion,
@Eps,
@Email,
@Profesion,
@Jornada,
@Num_Contacto,
'Activo'

) 
END ;
go

CREATE PROCEDURE ActualizarDocente
@IdentificacionDoc int,
@Nombres varchar(50),
@Apellidos varchar(50),
@Direccion varchar(50),
@Eps varchar(50),
@Email varchar(50),
@Profesion varchar(50),
@Jornada varchar(50),
@Num_Contacto varchar(30)


AS BEGIN 
 
UPDATE Docente
SET        
IdentificacionDoc = @IdentificacionDoc,
Nombres = @Nombres,
Apellidos = @Apellidos,
Direccion = @Direccion,
Eps = @Eps,
Email = @Email,
Profesion = @Profesion,
Jornada = @Jornada,
Num_Contacto = @Num_Contacto            
  WHERE IdentificacionDoc = @IdentificacionDoc             
END
go 
;


CREATE PROCEDURE ConsultarDocente
  @Valor varchar(50), 
  @Columna varchar(50) 
 
AS BEGIN 
 
IF @Columna = 'IdentificacionDoc'   SELECT * FROM Docente  WHERE IdentificacionDoc=@Valor 
 
Else IF @Columna = 'Nombres'   SELECT * FROM Docente    WHERE Nombres like  @Valor + '%' 
 
Else IF @Columna = 'Apellidos'   SELECT * FROM Docente WHERE Apellidos like  @Valor + '%' 

Else IF @Columna = 'Direccion'   SELECT * FROM Docente  WHERE Direccion like  @Valor + '%' 

Else IF @Columna = 'Eps'   SELECT * FROM Docente   WHERE Eps like  @Valor + '%' 

Else IF @Columna = 'Email'   SELECT * FROM Docente  WHERE Email like  @Valor + '%' 

Else IF @Columna = 'Profesion'   SELECT * FROM Docente  WHERE Profesion like  @Valor + '%' 

Else IF @Columna = 'Jornada'   SELECT * FROM Docente  WHERE Jornada like  @Valor + '%' 

Else IF @Columna = 'Num_Contacto'   SELECT * FROM Docente WHERE Num_Contacto like  @Valor + '%' 

Else if @Columna = 'Estado' Select * From Docente WHERE Estado like @Valor + '%'

End 
go
;

Create Procedure CambiarEstadoDoc
@IdentificacionDoc int
as begin

update Docente set Estado = 'Inactivo' , Id_Curso = NULL where IdentificacionDoc = @IdentificacionDoc

end
go
;



--Curso--

CREATE PROCEDURE ConsultarCurso
  @Valor varchar(50), 
  @Columna varchar(50) 
 
AS BEGIN 
 
IF @Columna = 'Id_Curso'   SELECT * FROM Curso  WHERE Id_Curso=@Valor 
 
Else IF @Columna = 'Num_Curso'   SELECT * FROM Curso  WHERE Num_Curso like  @Valor + '%' 
 
Else IF @Columna = 'Nivel'   SELECT * FROM Curso     WHERE Nivel like  @Valor + '%' 

Else IF @Columna = 'Jornada'   SELECT * FROM Curso    WHERE Jornada like  @Valor + '%' 


End 
go
;


CREATE PROCEDURE ConsultarCurso2
  @Valor1 varchar(30),
  @Valor2 varchar(30),
  @Columna varchar (50)
 
AS BEGIN 
 
if @Columna =  'JorYCur ' Select Id_Curso from Curso Where @Valor1 = Num_Curso and @Valor2 = Jornada

End 
go
;

Create procedure InsertarCurso
@Num_Curso varchar(10),
@Nivel varchar(30),
@Jornada varchar(20)

As begin

insert into Curso
(
Num_Curso,
Nivel,
Jornada
)

values

(
@Num_Curso,
@Nivel,
@Jornada
)
End
go


Create Procedure InsertarCursoEst
@IdentificacionEst int,
@Jornada varchar(30),
@Num_Curso varchar(30)

as begin 

update Estudiante set 
Id_Curso = (select Id_Curso From Curso where Jornada= @Jornada and Num_Curso = @Num_Curso)

where IdentificacionEst = @IdentificacionEst

End
go

Create Procedure InsertarCursoDoc
@IdentificacionDoc int,
@Jornada varchar(30),
@Num_Curso varchar(30)

as begin 

update Docente set 
Id_Curso = (select Id_Curso From Curso where Jornada= @Jornada and Num_Curso = @Num_Curso)

where IdentificacionDoc = @IdentificacionDoc

End
go

Create Procedure ConsultarCEst
@Id_Curso int

as begin

Select E.Nombres, E.Apellidos, E.Jornada, E.Num_Contacto as Contacto, C.Num_Curso as Curso, C.Nivel  from Estudiante as E 
inner join Curso as C on C.Id_Curso = E.Id_Curso where E.Id_Curso = (Select Id_Curso From Curso as C where C.Id_Curso = @Id_Curso)

end
go

Create procedure ActualizarCurso
@Id_Curso int,
@Num_Curso varchar(10),
@Nivel varchar(30),
@Jornada varchar(20)

as begin 

Update Curso 
set
 
 Num_Curso = @Num_Curso,
 Nivel = @Nivel,
 Jornada = @Jornada
 Where Id_Curso = @Id_Curso

 end
 go

 Create procedure EliminarCurso
 @Id_Curso int 

 as begin 

 delete from Curso where Id_Curso = @Id_Curso

 end
 go

  Create Procedure EliminarCursoD
@IdentificacionDoc int,
@Jornada varchar(30),
@Num_Curso varchar(30)

as begin 

update Docente set Id_Curso= Null
 where 
Id_Curso = (select Id_Curso From Curso where Jornada= @Jornada and Num_Curso = @Num_Curso) and IdentificacionDoc = @IdentificacionDoc



End
go

--Acudiente--

CREATE PROCEDURE [dbo].[InsertarAcudiente]   
@IdentificacionAcu int,
@Nombres varchar(50),
@Apellidos varchar(50),
@Direccion varchar(50),
@Eps varchar(50),
@Email varchar(50),
@Num_Contacto varchar(30)

AS BEGIN 
 
INSERT INTO Acudiente         
(
IdentificacionAcu     
,Nombres            
,Apellidos            
,Direccion            
,Eps
,Email
,Num_Contacto
,Estado
)      
VALUES            
(
@IdentificacionAcu,
@Nombres,
@Apellidos,
@Direccion,
@Eps,
@Email,
@Num_Contacto,
'Activo'

) 
END 
go

CREATE PROCEDURE ActualizarAcudiente
@IdentificacionAcu int,
@Nombres varchar(50),
@Apellidos varchar(50),
@Direccion varchar(50),
@Eps varchar(50),
@Email varchar(50),
@Num_Contacto varchar(30)
 AS BEGIN 
 
UPDATE Acudiente
SET        
IdentificacionAcu = @IdentificacionAcu,
Nombres = @Nombres,
Apellidos = @Apellidos,
Direccion = @Direccion,
Eps = @Eps,
Email = @Email,
Num_Contacto = @Num_Contacto            
  WHERE IdentificacionAcu = @IdentificacionAcu             
END 
go


CREATE PROCEDURE ConsultarAcudiente
  @Valor varchar(50), 
  @Columna varchar(50) 
 
AS BEGIN 
 
IF @Columna = 'IdentificacionAcu'   SELECT * FROM Acudiente   WHERE IdentificacionAcu=@Valor 
 
Else IF @Columna = 'Nombres'   SELECT * FROM Acudiente    WHERE Nombres like  @Valor + '%' 
 
Else IF @Columna = 'Apellidos'   SELECT * FROM Acudiente   WHERE Apellidos like  @Valor + '%' 

Else IF @Columna = 'Direccion'   SELECT * FROM Acudiente  WHERE Direccion like  @Valor + '%' 

Else IF @Columna = 'Eps'   SELECT * FROM Acudiente   WHERE Eps like  @Valor + '%' 

Else IF @Columna = 'Email'   SELECT * FROM Acudiente   WHERE Email like  @Valor + '%' 

Else IF @Columna = 'Num_Contacto'   SELECT * FROM Acudiente  WHERE Num_Contacto like  @Valor + '%' 

Else if @Columna = 'Estado' Select * From Acudiente WHERE Estado like @Valor + '%'

End 
go
;

Create Procedure CambiarEstadoAcu
@IdentificacionAcu int
as begin

update Acudiente set Estado = 'Inactivo'  where IdentificacionAcu = @IdentificacionAcu

end
go
;



--Estudiante--

CREATE PROCEDURE [dbo].[InsertarEstudiante]   
@IdentificacionEst int,
@Nombres varchar(50),
@Apellidos varchar(50),
@Direccion varchar(50),
@Eps varchar(50),
@Email varchar(50),
@Jornada varchar(20),
@Num_Contacto varchar(30)

AS BEGIN 
 
INSERT INTO Estudiante          
(
IdentificacionEst          
,Nombres            
,Apellidos            
,Direccion            
,Eps
,Email
,Jornada
,Num_Contacto
,Estado
)      
VALUES            
(
@IdentificacionEst,
@Nombres,
@Apellidos,
@Direccion,
@Eps,
@Email,
@Jornada,
@Num_Contacto,
'Activo'

) 
END 
go

CREATE PROCEDURE ActualizarEstudiante
@IdentificacionEst int,
@Nombres varchar(50),
@Apellidos varchar(50),
@Direccion varchar(50),
@Eps varchar(50),
@Email varchar(50),
@Jornada varchar(20),
@Num_Contacto varchar(30)
 AS BEGIN 
 
UPDATE Estudiante
SET        
IdentificacionEst = @IdentificacionEst,
Nombres = @Nombres,
Apellidos = @Apellidos,
Direccion = @Direccion,
Eps = @Eps,
Email = @Email,
Jornada = @Jornada,
Num_Contacto = @Num_Contacto            
  WHERE IdentificacionEst = @IdentificacionEst             
END 
go


CREATE PROCEDURE ConsultarEstudiante
  @Valor varchar(50), 
  @Columna varchar(50) 
 
AS BEGIN 
 
IF @Columna = 'IdentificacionEst'   SELECT * FROM Estudiante    WHERE IdentificacionEst=@Valor 
 
Else IF @Columna = 'Nombres'   SELECT * FROM Estudiante   WHERE Nombres like  @Valor + '%' 
 
Else IF @Columna = 'Apellidos'   SELECT * FROM Estudiante   WHERE Apellidos like  @Valor + '%' 

Else IF @Columna = 'Direccion'   SELECT * FROM Estudiante   WHERE Direccion like  @Valor + '%' 

Else IF @Columna = 'Eps'   SELECT * FROM Estudiante   WHERE Eps like  @Valor + '%' 

Else IF @Columna = 'Email'   SELECT * FROM Estudiante   WHERE Email like  @Valor + '%' 

Else IF @Columna = 'Jornada'   SELECT * FROM Estudiante   WHERE Jornada like  @Valor + '%' 

Else IF @Columna = 'Num_Contacto'   SELECT * FROM Estudiante   WHERE Num_Contacto like  @Valor + '%' 

Else if @Columna = 'Estado' Select * From Estudiante WHERE Estado like @Valor + '%'

Else if @Columna = 'Id_Curso' Select * From Estudiante WHERE Id_Curso like @Valor + '%'

Else if @Columna = 'IdentificacionAcu'  SELECT * FROM Estudiante WHERE IdentificacionAcu=@Valor 

End 
go


CREATE PROCEDURE EliminarEstudiante     
@IdentificacionEst int          
 AS BEGIN 

DELETE FROM Estudiante WHERE IdentificacionEst = @IdentificacionEst; 

END 
go

Create Procedure CambiarEstadoEst2
@IdentificacionEst int
as begin

update Estudiante set Estado = 'Inactivo'  where IdentificacionEst = @IdentificacionEst

end
go

Create Procedure AsignarAcu
@IdentificacionEst int,
@IdentificacionAcu int

as begin 

Update Estudiante set IdentificacionAcu = @IdentificacionAcu where IdentificacionEst = @IdentificacionEst

end
go

--Sesion--




CREATE PROCEDURE ConsultaLogin
@Usuario int,
@Tipo_Usuario varchar(50),
@Contraseña varchar(50)
as
begin
select Usuario from Sesion where @Usuario = Usuario and @Contraseña = Contraseña and @Tipo_Usuario = Tipo_Usuario;
end
go


CREATE PROCEDURE [dbo].[InsertarSesion]   
@Usuario int,
@Tipo_Usuario varchar(50),
@Contraseña varchar(50)

AS BEGIN 
 
INSERT INTO Sesion         
(
Usuario
,Tipo_Usuario
,Contraseña
)      
VALUES            
(
@Usuario
,@Tipo_Usuario
,@Contraseña
) 
END
go

CREATE PROCEDURE ConsultarSesion
  @Valor varchar(50), 
  @Columna varchar(50) 
 
AS BEGIN 
 
IF @Columna = 'Id_Sesion'  SELECT * FROM Sesion WHERE Id_Sesion=@Valor 
 
Else IF @Columna = 'Usuario'  SELECT * FROM Sesion WHERE Usuario=@Valor
 
Else IF @Columna = 'Tipo_Usuario'  SELECT * FROM Sesion WHERE Tipo_Usuario like  @Valor + '%' 

Else IF @Columna = 'Contraseña'  SELECT * FROM Sesion WHERE Contraseña=@Valor  

End 
go

	CREATE PROCEDURE ActualizarEstudianteSesion
	@IdentificacionEst int,
	@Id_Sesion int
	 AS BEGIN 
 
	UPDATE Estudiante
	SET        
	Id_Sesion = @Id_Sesion          
	  WHERE IdentificacionEst = @IdentificacionEst             
	END 
	go

CREATE PROCEDURE ActualizarAcudienteSesion
@IdentificacionAcu int,
@Id_Sesion int
 AS BEGIN 
 
UPDATE Acudiente
SET        
Id_Sesion = @Id_Sesion          
  WHERE IdentificacionAcu = @IdentificacionAcu            
END 
go

CREATE PROCEDURE ActualizarDocenteSesion
@IdentificacionDoc int,
@Id_Sesion int
 AS BEGIN 
 
UPDATE Docente
SET        
Id_Sesion = @Id_Sesion          
  WHERE IdentificacionDoc = @IdentificacionDoc          
END 
go


CREATE PROCEDURE ActualizarSesion
@Usuario int,
@Contraseña varchar(50)

 AS BEGIN 
 
UPDATE Sesion
SET        
Usuario = @Usuario,
Contraseña = @Contraseña          
WHERE Usuario = @Usuario             
END 
go



CREATE PROCEDURE EliminarSesion     
@Usuario int          
 AS BEGIN 

DELETE FROM Sesion WHERE Usuario =  @Usuario; 

END 
go

Create procedure CambiarContraseña
@Usuario int,
@Contraseña varchar(50)

as begin

update Sesion set Contraseña = @Contraseña where Usuario = @Usuario

end
go


--X--


insert into Sesion (Usuario,Tipo_Usuario,Contraseña) values (123, 'Administrador', '123');

insert into Administrador (IdentificacionAdm, Nombres, Apellidos, Direccion, Eps, Email, Num_Contacto,Id_Sesion) 
values (123,'James', 'Angarita Garcia', 'Cll14 b sur #4 89', 'Medimas', 'James@gmail.com', '0000',1);







