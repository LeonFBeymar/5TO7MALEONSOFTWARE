DELIMITER $$
USE softwarefactory $$
SELECT 'Creando SPSF' AS 'Estado' $$


CREATE PROCEDURE AltaTecnologia (unidTecnologia TINYINT, unaTecnologia VARCHAR(20), unCostoBase DECIMAL(10,2))
BEGIN
	INSERT INTO Tecnologia (idTecnologia, Tecnologia, CostoBase)
				VALUES (unidTecnologia, unaTecnologia, unCostoBase);
END $$

DELIMITER $$
CREATE PROCEDURE AltaRequerimiento (unidRequerimiento INT, unidProyecto SMALLINT, unidTecnologia TINYINT, unaDescripcion VARCHAR(45), unaComplejidad TINYINT UNSIGNED)
BEGIN
	INSERT INTO Requerimiento (idRequerimiento, idProyecto, idTecnologia, Descripcion, Complejidad)
				VALUES (unidRequerimiento, unidProyecto, unidTecnologia, unaDescripcion, unaComplejidad);
END $$

DELIMITER $$
CREATE PROCEDURE AltaTarea (unidRequerimiento INT, unCuil INT, unInicio DATE, unFin DATE)
BEGIN
	INSERT INTO Tarea (idRequerimiento, Cuil, inicio, fin)
				VALUES (unidRequerimiento, unCuil, unInicio, unFin);
END $$

DELIMITER $$
CREATE PROCEDURE AltaProyecto (unidProyecto SMALLINT, unCuit INT, unaDescripcion VARCHAR(200), unPresupuesto DECIMAL(10,2), unInicio DATE, unFin DATE)
BEGIN
	INSERT INTO Proyecto (idProyecto, Cuit, Descripcion, Presupuesto, inicio, fin)
				VALUES (unidProyecto, unCuit, unaDescripcion, unPresupuesto, unInicio, unFin);
END $$


DELIMITER $$
CREATE PROCEDURE AltaCliente (unCuit INT, unaRazonSocial VARCHAR(50))
BEGIN
	INSERT INTO Cliente (Cuit, RazonSocial)
				VALUES (unCuit, unaRazonSocial);
END $$

DELIMITER $$
CREATE PROCEDURE AltaEmpleado (unCuil INT, unNombre VARCHAR(50), unApellido VARCHAR(50), unaContratacion DATE)
BEGIN
	INSERT INTO Empleado (Cuil ,Nombre, Apellido, Contratacion)
				VALUES (unCuil, unNombre, unApellido, unaContratacion);
END $$



DELIMITER $$
CREATE PROCEDURE AsignarExperiencia (unCuil INT, unidTecnologia TINYINT, unaCalificacion TINYINT UNSIGNED)
BEGIN
    
    
    
    if(EXISTS(SELECT Calificacion
		FROM Experiencia 
		WHERE cuil = unCuil
		AND idTecnologia = unidTecnologia))Then
					UPDATE Experiencia
					SET Calificacion = unaCalificacion
					WHERE Cuil = unCuil
                    AND idTecnologia = unidTecnologia;
		else
		INSERT INTO Experiencia (Cuil, idTecnologia, Calificacion)
				VALUES (unCuil, unidTecnologia, unaCalificacion);
	end if;
    
END $$


DELIMITER $$
CREATE PROCEDURE finalizarTarea (unidRequerimiento INT, unCuil INT, unFin DATE)
BEGIN
	UPDATE Tarea
    SET Fin = unFin
    WHERE Cuil = unCuil
    AND fin is null;
END $$


DELIMITER $$
CREATE FUNCTION complejidadPromedio (unIdProyecto SMALLINT) RETURNS FLOAT
BEGIN 
	DECLARE promedioComplejidad FLOAT;
    
    SELECT AVG(complejidad) INTO promedioComplejidad
    FROM requerimiento 	
    WHERE idProyecto = unIdProyecto;
    
    RETURN promedioComplejidad;
    
END $$


DELIMITER $$
CREATE FUNCTION sueldoMensual (unCuil INT) RETURNS DECIMAL(10.2)
BEGIN
	DECLARE sueldoApagar DECIMAL(10.2);
    
SELECT TIMESTAMPDIFF(YEAR, contratacion, CURDATE()) * 1000 + SUM(calificacion * costoBase) INTO sueldoApagar
    FROM experiencia E
    INNER JOIN empleado EM on E.cuil = EM.cuil
    INNER JOIN Tecnologia T on E.idTecnologia = T.idTecnologia
    WHERE EM.cuil = unCuil;
    
    RETURN sueldoApagar;
END $$


DELIMITER $$
CREATE FUNCTION costoProyecto (unIdProyecto SMALLINT) RETURNS DECIMAL(10.2)
BEGIN
	DECLARE costoDelProyecto DECIMAL(10.2);
    
    SELECT SUM(complejidad * costoBase) INTO costoDelProyecto
    FROM requerimiento R
    INNER JOIN tecnologia T ON R.idTecnologia = T.idTecnologia
    WHERE idProyecto = unIdProyecto;
    
    RETURN costoDelProyecto;
END $$